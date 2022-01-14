using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class Building : MonoBehaviour
{

    public BuildingScriptable scriptable;
    public GameObject rewardFeedbackObject;
    public Transform meshParent;
    public GameObject buildingUIObject;
    public BuildingUI buildingUI;

    public void Build(int index)
    {
        //TODO Start building
        var toBuild = scriptable.nextBuilding[index];
        if (meshParent.childCount > 0)
        {
            //TODO use pool 
            var children = meshParent.GetComponentsInChildren<Transform>();
            foreach (var c in children)
            {
                Destroy(c.gameObject);
            }
        }
        var temp = Instantiate(toBuild.buildingMesh, meshParent, true);
        temp.transform.localPosition = Vector3.zero;
        //TODO Run timer before building TriggerTimer();
        scriptable = toBuild;
        buildingUI.RefreshUI();
    }

    public void TriggerTimer()
    {
        //TODO trigget timer and show time in rewardFeedbackObject ui
    }
    
    public void GenerateMoney()
    {
        Player.AddMoney(scriptable.moneyGenerated);
        TriggerFeedbackAnimation(scriptable.moneyGenerated, Constants.MoneyCode);
    }
    
    public void GenerateBitcoin()
    {
        Player.AddBitcoin(scriptable.bitcoinGenerated);
        TriggerFeedbackAnimation(scriptable.bitcoinGenerated, Constants.BitcoinCode);
    }

    public void GenerateMaterial()
    {
        Player.AddMaterial(scriptable.materialGenerated);
        TriggerFeedbackAnimation(scriptable.materialGenerated, Constants.MaterialCode);
    }

    public void Defend()
    {
        //TODO : look for enemies and shoot on sight
    }

    public void AttractPeople()
    {
        Game.AttractPeople();
    }
    
    private void TriggerFeedbackAnimation(int value, int resource)
    {
        Instantiate(rewardFeedbackObject, this.transform.position, Quaternion.identity).GetComponent<FeedbackAnimation>()
            .ShowText(value, resource);

    }

    public void OpenUI()
    {
        buildingUIObject.SetActive(true);
    }
}