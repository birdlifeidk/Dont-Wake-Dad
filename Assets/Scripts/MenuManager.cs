using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using Scene = UnityEditor.SearchService.Scene;

public class MenuManager : MonoBehaviour
{
    public float delayTime = 3f;

    public void PlayGame()
    {
        SceneManager.LoadScene("FinalGameScene");
        Debug.Log("hi there");
    }

    public void IntroScene()
    {
        SceneManager.LoadScene("Introduction"); 
    }

    public void EndGame()
    {
        SceneManager.LoadScene("YouLose");
    }

    public void WinGame()
    {
        SceneManager.LoadScene("YouWin");
    }



    

    // public void GetDelayed()
    // {
    //     if ("YouLose" != null)
    //     {
    //         delayTime.Equals(true);
    //         Debug.Log("Delayed");
    //         
    //     }
    // }
    
}
