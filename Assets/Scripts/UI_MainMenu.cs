using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class UI_MainMenu : MonoBehaviour
{
    public TMP_InputField inputField_playerName;
    public GameObject button_Start;


    private void Start()
    {

    }


    public void LoadNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Quit()
    {

#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }

    public void ShowStartButton()
    {
        button_Start.SetActive(true);
    }
    public void SaveName()
    {
        PlayerName.playerName = inputField_playerName.text;
    }
}
