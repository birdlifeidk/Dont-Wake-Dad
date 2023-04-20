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
    public PickUpSnack _pickUpSnack;
    public int Score; 
    

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
        Score = 0; 
        SceneManager.LoadScene("YouLose");
        
      
    }

    public void WinGame()
    {
        SceneManager.LoadScene("YouWin");
    }

    public void StartGame()
    {
        SceneManager.LoadScene("GameMenu");
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
