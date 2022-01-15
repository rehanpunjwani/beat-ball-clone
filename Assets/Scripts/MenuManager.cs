using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public static MenuManager Instance { get; private set; }
    public string name;
    public int highScore;
    private void Awake()
    {
        if(Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        LoadData();
        DontDestroyOnLoad(gameObject);


    }


    public void SaveData()
    {
        PlayerData data = new PlayerData();
        data.name = name;
        data.score = highScore;

        string json = JsonUtility.ToJson(data);
        File.WriteAllText( Application.persistentDataPath + "/user.json", json);
    }

    public void LoadData()
    {
        string path = Application.persistentDataPath + "/user.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            PlayerData data = JsonUtility.FromJson<PlayerData>(json);

            name = data.name;
            highScore = data.score;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [Serializable]
    class PlayerData
    {
       public string name;
        public int score;
    }
}
