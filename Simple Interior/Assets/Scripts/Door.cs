using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour, IUnit
{

   public List<Vector3> Opendoorlist = new List<Vector3>();
   public List<Vector3> ClosedDoorList = new List<Vector3>();
    public Vector3 GetDoor1Cords()
    {
        return this.gameObject.transform.GetChild(1).position;
    }

    public Vector3 GetDoor2Cords()
    {
        return this.gameObject.transform.GetChild(1).position;
    }

    public int GetDoorAmount()
    {
        throw new System.NotImplementedException();
    }

    public List<Vector3> GetDoorCordsCollection()
    {
        throw new System.NotImplementedException();
    }

    public Vector3 GetPosition()
    {
        throw new System.NotImplementedException();
    }

    public void SetDoor1Cords(Vector3 doorCords1)
    {
        this.gameObject.transform.GetChild(1).position = doorCords1;
    }

    public void SetDoor2Cords(Vector3 doorCords2)
    {
        this.gameObject.transform.GetChild(2).position = doorCords2;
    }

    public void SetDoorAmount(int doorAmount)
    {
        throw new System.NotImplementedException();
    }

    public void SetDoorCords(Vector3 doorCords)
    {
        this.gameObject.transform.position = doorCords;
    }

    public void SetDoorCordsCollection(List<Vector3> doorcollectionList)
    {
        


    }

    public void SetPosition(Vector3 position)
    {
        throw new System.NotImplementedException();
    }

/*    public void AddToList()
    {
        Opendoorlist.Add(Find);

        foreach(Vector3 i in Opendoorlist)
        {
            Debug.Log(i);
        }
    }*/

    


}
