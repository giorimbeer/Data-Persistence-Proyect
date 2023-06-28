using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Singleton : MonoBehaviour
{
    public static Singleton Instance;
    public string name;
    public string nameActual;
    public int points = 0;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        LoadData();
    }

    public void SaveData()
    {
        User data = new User();
        data.name = nameActual;
        data.points = points;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "user.json", json);
    }

    public void LoadData()
    {
        string rute = Application.persistentDataPath + "user.json";

        User dat = new User();

        if(rute != null)
        {
            string json = File.ReadAllText(rute);
            dat = JsonUtility.FromJson<User>(json);
        }
        else dat = null;
        
        //if (dat.name == "") dat.name = "default name";

        name = dat.name;
        points = dat.points;

    }

    [System.Serializable]
    class User
    {
        public string name;
        public int points;
    }
}
