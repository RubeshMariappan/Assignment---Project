using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Savedata 
{   
    
    public int m_openedDoors;

    public string ToJson()
    {
        return JsonUtility.ToJson(this);
    }

    public void LoadFromJson(string a_json)
    {

        JsonUtility.FromJsonOverwrite(a_json, this);
    }

}

public interface ISavable
{
    void PopulateSaveData(Savedata a_savedata);
    void LoadFromSaveData(Savedata a_savedata);

}
