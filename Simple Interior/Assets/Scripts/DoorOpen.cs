using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorOpen : MonoBehaviour
{
    [Header("")]
    public float TheDistance;
    public GameObject actionKey;
    public GameObject actionText;
    public GameObject TheDoor;
    public AudioSource creakSound;
  


    void Update()
    {
        TheDistance = PlayerCasting.distanceFromTarget;
    
    }

    private void OnMouseOver()
    {
        if(TheDistance <=3)
        {
            actionKey.SetActive(true);
            actionText.SetActive(true);
        }

        if(Input.GetButtonDown("action"))
        {
            if(TheDistance<=2)
            {
                OpenDoorState();
                // TheDoor.GetComponentInChildren<Animation>().Play();
            }

        }


    }


    private void OnMouseExit()
    {
        actionText.SetActive(false);
        actionKey.SetActive(false);
    }


    public void OpenDoorState()
    {
        
        this.GetComponent<BoxCollider>().enabled = false;
        actionText.SetActive(false);
        actionKey.SetActive(false);
        TheDoor.transform.GetChild(1).GetComponent<Animation>().Play("LeftDoorOpenAnim");
        TheDoor.transform.GetChild(2).GetComponent<Animation>().Play("RightDoorOpenAnim");
        //FindObjectOfType<Door>().AddToList();
        
    }

   

    


    
}
