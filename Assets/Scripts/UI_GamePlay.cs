using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_GamePlay : MonoBehaviour
{
    public MainManager mainManager;

    public Text playerName;
    public Text ScoreText;
    public Text HighestScoreText;
    public GameObject GameOverText;



    public void Awake()
    {
        playerName.text = playerName.text + PlayerName.playerName;
        HighestScoreText.text = "HighScore : " + HighestScore.Value.ToString();
    }

    public void UpdateScore()
    {
        ScoreText.text = "Score : " + mainManager.GetPoints();
    }

    public void ShowGameOver()
    {
        GameOverText.SetActive(true);
    }
}
