using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IUnit  
{

    Vector3 GetPosition();

    void SetPosition(Vector3 position);

    int GetDoorAmount();

    void SetDoorAmount(int doorAmount);


    Vector3 GetDoor1Cords();

    void SetDoor1Cords(Vector3 doorCords1);

    Vector3 GetDoor2Cords();
    void SetDoor2Cords(Vector3 doorCords2);

    List<Vector3> GetDoorCordsCollection();
    void SetDoorCordsCollection(List<Vector3> doorcollectionList);



}
