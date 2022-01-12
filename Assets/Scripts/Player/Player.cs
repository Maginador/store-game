using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{
    [SerializeField] private Camera mainCamera;
    [SerializeField] private GameObject debugObj;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            var mousePosition = new Vector3(Input.mousePosition.x,Input.mousePosition.y, mainCamera.nearClipPlane);
            var position = mainCamera.ScreenToWorldPoint(mousePosition);
            var direction = position - mainCamera.transform.position;
            RaycastHit hit;
            if (Physics.Raycast(mainCamera.transform.position, direction, out hit,100))
            {
                if (hit.collider.CompareTag("MovableArea"))
                {
                    this.Move(hit.point);
                    debugObj.transform.position = hit.point;
                }
                
            }
           
        }
    }
    
    
}
