using UnityEngine;

[CreateAssetMenu(fileName = "new building", menuName = "ScriptableObject/Building")]
public class BuildingScriptable : ScriptableObject
{
    public GameObject buildingMesh;
    public BuildingScriptable[] nextBuilding;
    public int cost;
    public Function function;
    public int materialGenerated;
    public int bitcoinGenerated;
    public int moneyGenerated;
    public int attack, attackSpeed;
    public int attractionFactor;

}