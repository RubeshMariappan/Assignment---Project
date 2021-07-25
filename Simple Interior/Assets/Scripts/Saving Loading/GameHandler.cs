using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using CodeMonkey;
using CodeMonkey.Utils;

public class GameHandler : MonoBehaviour
{
    [SerializeField]  GameObject unitGameObject;
    [SerializeField] GameObject door;
    private IUnit unit;
    private IUnit doorData;
    CharacterController controller;
    Door doorRef;


    private void Awake()
    {
        unit = unitGameObject.GetComponent<IUnit>();
        doorData = door.GetComponent<IUnit>();
       

        SaveObject saveObject = new SaveObject {

            doorAmount = 2,
        };

        string json = JsonUtility.ToJson(saveObject);
        Debug.Log(json);

        SaveObject loadedSaveObject = JsonUtility.FromJson<SaveObject>(json);
        Debug.Log(loadedSaveObject.doorAmount);


    }
    void Start()
    {
        controller = unitGameObject.GetComponent<CharacterController>();
        doorRef = door.GetComponent<Door>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.P))
        {
            Save();
        }

        if(Input.GetKeyDown(KeyCode.L))
        {
            Load();
        }
    }


    private void Save()
    {

        Vector3 playerPosition = unit.GetPosition();
        int TotaldoorAmount = unit.GetDoorAmount();

        SaveObject saveObject = new SaveObject
        {
            doorAmount = TotaldoorAmount,
            playerPos = playerPosition,
            doorCordsCollection = doorRef.Opendoorlist,
        };

        string json = JsonUtility.ToJson(saveObject);

        File.WriteAllText(Application.dataPath + "/save.txt", json);

        CMDebug.TextPopupMouse("Saved !");

    }

    private void Load()
    {
        if(File.Exists(Application.dataPath + "/save.txt"))
        {

            string saveString = File.ReadAllText(Application.dataPath + "/save.txt");
            SaveObject saveObject = JsonUtility.FromJson<SaveObject>(saveString);
            Debug.Log("Loaded");

            unit.SetPosition(saveObject.playerPos);
            unit.SetDoorAmount(saveObject.doorAmount);
            controller.enabled = true;
            
        }

        else
        {
            Debug.Log("No Save");
        }

    }
}

public class SaveObject
{

    public int doorAmount;
    public Vector3 playerPos; 
    public List<Vector3> doorCordsCollection;
   
}
