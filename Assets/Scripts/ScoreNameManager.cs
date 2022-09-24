using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
public class ScoreNameManager : MonoBehaviour
{

    public static int bestScore;
    public static string charName;
    public static string bestName;

    private void Start()
    {
        DontDestroyOnLoad(gameObject);
    }


    [System.Serializable]
    class SaveData
    {
        public int bestScore;
        public string bestName;
    }
    public static void SaveBestScore()
    {
        SaveData data = new SaveData();
        data.bestScore = bestScore;
        data.bestName = bestName;
        string json = JsonUtility.ToJson(data);
        File.WriteAllText(Application.persistentDataPath + "/bestscoresave.json", json);
    }

    public static void LoadBestScore()
    {
        string path = Application.persistentDataPath + "/bestscoresave.json";

        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            bestScore = data.bestScore;
            bestName = data.bestName;
        }
        else
        {
            bestScore = 0;
            bestName = "Nobody";
        }
    }
    public static void UpdateUI()
    {

    }
}
