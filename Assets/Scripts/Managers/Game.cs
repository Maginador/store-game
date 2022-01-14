using System;
using UnityEngine;

public class Game : MonoBehaviour
{

    public Game Instance;

    private void Start()
    {
        if(Instance != null) Destroy(Instance);

        Instance = this;
    }

    public static void AttractPeople()
    {
    }
}