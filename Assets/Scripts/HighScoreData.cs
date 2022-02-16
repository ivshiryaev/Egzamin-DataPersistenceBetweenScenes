using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class HighScoreData : MonoBehaviour
{
    public static int HighScore { get; set; }
    public static string playerName { get; set; }

    private void Awake()
    {
        LoadDataFromJSON();
    }
    private void Start()
    {
        Debug.Log("HighScoreData Start method");
    }


    public static void SaveHighScore(int value)
    {
        if (IsValueHigherThenCurrentHighScore(value))
        {
            HighScore = value;
            playerName = PlayerName.playerName;
            SaveDataToJSON();
        }
    }
    private static bool IsValueHigherThenCurrentHighScore(int value)
    {
        return value > HighScore ? true : false;
    }





    [System.Serializable]
    class SaveData
    {
        public int score;
        public string name;
    }

    private static void SaveDataToJSON()
    {
        SaveData saveData = new SaveData();
        saveData.score = HighScore;
        saveData.name = playerName;

        string json = JsonUtility.ToJson(saveData);
        File.WriteAllText(Application.persistentDataPath + "/highscore.json", json);
    }
    private static void LoadDataFromJSON()
    {

        string path = File.ReadAllText(Application.persistentDataPath + "/highscore.json");

        SaveData loadData = JsonUtility.FromJson<SaveData>(path);

        playerName = loadData.name;
        HighScore = loadData.score;
    }
}
