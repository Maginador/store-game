using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{
    [SerializeField] private Camera mainCamera;
    [SerializeField] private GameObject debugObj;
    private static PlayerStats stats; 
    // Start is called before the first frame update
    void Start()
    {
        stats = new PlayerStats();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            var mousePosition = new Vector3(Input.mousePosition.x,Input.mousePosition.y, mainCamera.nearClipPlane);
            var position = mainCamera.ScreenToWorldPoint(mousePosition);
            var direction = position - mainCamera.transform.position;
            if (Physics.Raycast(mainCamera.transform.position, direction, out var hit,100))
            {
                if (hit.collider.CompareTag("MovableArea"))
                {
                    Move(hit.point);
                    debugObj.transform.position = hit.point;
                }

                if (hit.collider.CompareTag("Building"))
                {
                    hit.transform.GetComponent<Building>().OpenUI();
                }
                
            }
           
        }
    }

    public static void AddMoney(int money)
    {
        stats.money += money;
    }

    public static void AddBitcoin(int bitcoin)
    {
        stats.bitcoin += bitcoin;
    }

    public static void AddMaterial(int material)
    {
        stats.materials += material;
    }
    
}