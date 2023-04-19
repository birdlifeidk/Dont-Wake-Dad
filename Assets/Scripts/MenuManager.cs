using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public float delayTime = 3f;

    public void PlayGame()
    {
        SceneManager.LoadScene("FinalGameScene");
        Debug.Log("hi there");
    }

    public void EndGame()
    {
        
        SceneManager.LoadScene("YouLose");
        Debug.Log("You lost!");             
        //Invoke("GetDelayed", delayTime);

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
