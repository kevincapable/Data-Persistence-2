using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEditor;
using TMPro;


public class MenuUIHandler : MonoBehaviour
{
    
    public GameObject nameInputField;
    public GameObject bestScoreField;
    public GameObject scoreManager;
    private void Start()
    {
       ScoreNameManager.LoadBestScore();
        Debug.Log(ScoreNameManager.bestScore);
       bestScoreField.GetComponent<TMP_Text>().text = "Best Score : " + ScoreNameManager.bestName + " : " + ScoreNameManager.bestScore.ToString();
    }
    public void StartNew()
    {
        ScoreNameManager.charName = nameInputField.GetComponent<TMP_InputField>().text;
        SceneManager.LoadScene(1);
    }
    public void Exit()
    {

#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }




}
