using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingUI : MonoBehaviour
{
    [SerializeField] private GameObject[] buildButtons;
    [SerializeField] private Building building;
    // Start is called before the first frame update

    public void Start()
    {
        RefreshUI();
        
    }

    public void RefreshUI()
    {
        var quantity = building.scriptable.nextBuilding.Length;
        for (var i = quantity; i < buildButtons.Length; i++)
        {
            buildButtons[i].SetActive(false);
        }
    }

    public void OnBuild(int index)
    {
        building.Build(index);
    }
}
