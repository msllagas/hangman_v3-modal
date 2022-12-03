using Firebase.Database;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Firebase;
using TMPro;

public class DatabaseManager : MonoBehaviour
{
    public TMP_Text TotalWins;
    public TMP_Text TotalLosses;
    public TMP_Text GamesPlayed;
    public TMP_Text WinRatio;
    //public TMP_Text FastestTime;
    // Start is called before the first frame update
    private string userID;
    private DatabaseReference dbReference;
    void Start()
    {
        userID = SystemInfo.deviceUniqueIdentifier;
        dbReference = FirebaseDatabase.DefaultInstance.RootReference;
    }

    // Update is called once per frame
    public void CreateUser()
    {
        User newUser = new User(int.Parse(TotalWins.text), int.Parse(TotalLosses.text), int.Parse(GamesPlayed.text), float.Parse(WinRatio.text));
        string json = JsonUtility.ToJson(newUser);

        dbReference.Child("users").Child(userID).SetRawJsonValueAsync(json);
    }
}
