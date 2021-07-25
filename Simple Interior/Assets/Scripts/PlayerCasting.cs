using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCasting : MonoBehaviour
{

    public static float distanceFromTarget;
    public  float ToTarget;
    public int doors = 2;
   
 
    CharacterController controller;

   

    private void Start()
    {

        controller = this.GetComponent<CharacterController>();

    }

   

    void Update()
    {
        RaycastHit hit;
        if(Physics.Raycast(transform.position,transform.TransformDirection(Vector3.forward),out hit))
        {
            ToTarget = hit.distance;
            distanceFromTarget = ToTarget;

        }

        
    }

    
}
