using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class PersistenceManager : MonoBehaviour
{
    public static PersistenceManager Instance;
    public string name;

    public int HighScore = 0;
    public string HighScoreName;

    private void Update()
    {

    }

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        LoadHighScore();

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    [System.Serializable]
    class SaveData
    {
        public int Highscore;
        public string HighScoreName;
    }

    public void SaveHighScore()
    {
        SaveData data = new SaveData();
        data.Highscore = HighScore;
        data.HighScoreName = HighScoreName;

        string json = JsonUtility.ToJson(data);
        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void LoadHighScore()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            HighScore = data.Highscore;
            HighScoreName = data.HighScoreName;
        }        
    }
}
