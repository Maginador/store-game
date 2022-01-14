using System;
using UnityEngine;

[Serializable]
public class Function
{
    
    public enum FunctionSelection {MoneyGeneration, BitcoinGeneration, MaterialGeneration, Defense, People}

    public FunctionSelection[] buildingFunctions;

    public void RunFunction(Building building)
    {
        foreach (var func in buildingFunctions)
        {
            Execute(func, building);
        }
    }

    private void Execute(FunctionSelection func, Building building)
    {
        switch (func)
        {
            case FunctionSelection.MoneyGeneration:
                building.GenerateMoney();
                break;
            case FunctionSelection.BitcoinGeneration:
                building.GenerateBitcoin();
                break;
            case FunctionSelection.MaterialGeneration:
                building.GenerateMaterial();
                break;
            case FunctionSelection.Defense:
                building.Defend();
                break;
            case FunctionSelection.People:
                building.AttractPeople();
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(func), func, null);
        }
    }
    
}