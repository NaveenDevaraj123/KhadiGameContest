using System.Collections;
using Firebase.Extensions;
using Firebase;
using System.Collections.Generic;
using UnityEngine;
using Firebase.Firestore;
// using Firebase.Auth;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Events;


public class UserDetails : MonoBehaviour
{
    FirebaseFirestore db;
    Dictionary<string, object> user;
    [SerializeField] GameObject defalultPlayer,LogoutPanel,createAvatar;
    [SerializeField] GameObject Avatarsavepanel, AccountConfrim_Obj, confrim_Option_Obj;

    [SerializeField] TMP_Text user_Name, user_Name_Input, user_Name_Placeholder, OTP_Input, logText;
    [SerializeField] private UnityEvent _readEvent;
    [SerializeField] List<GameObject> orientedObjects;
    
    // Start is called before the first frame update
    void Awake()
    {
        db = FirebaseFirestore.DefaultInstance;
    }
    void Start()
    {
        // savedata();
    }

    public void CreateNewUserId()
    {

    }

    public void savedata()
    {
        DocumentReference addedDocRef = db.Collection("user").Document();
        Debug.Log("Added document with ID: {0}."+ addedDocRef.Id);
        user = new Dictionary<string, object>
        {
            {"ProviderID",addedDocRef.Id},
            {"Score", "10"},
            {"Username","5484874"},
        };
        addedDocRef.SetAsync(user).ContinueWithOnMainThread(task =>
        {
            Debug.Log("Added data to the {0} document in the cities collection." + addedDocRef.Id);
            PlayerPrefs.SetString("ProviderId", addedDocRef.Id.ToString());
        });

    }

}
