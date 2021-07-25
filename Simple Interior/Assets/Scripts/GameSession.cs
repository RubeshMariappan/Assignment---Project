using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Firebase.Database;
using Firebase.Auth;
using TMPro;

public class GameSession : MonoBehaviour
{
    // private GameSession() { }
    private static GameSession instance;

    FirebaseAuth auth;
    public TextMeshProUGUI userName;
    public TextMeshProUGUI openedDoors;
    public TextMeshProUGUI closedDoors;


    private void Awake()
    {


        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);


        auth = FirebaseAuth.DefaultInstance;
        FirebaseUser user = auth.CurrentUser;


        string name = user.DisplayName;
        userName.text = name;


    }


    private static void SaveJsonData(GameSession m_gameSession)
    {
        Savedata sd = new Savedata();
        


    }

    private static void LoadJsonData(GameSession a_gameSession)
    {



    }




 





}
