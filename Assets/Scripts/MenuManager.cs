using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    
    
    public void PlayGame()
    {
        SceneManager.LoadScene("FinalGameScene");
        Debug.Log("hi there");
    }
    
    

    public void EndGame()
    {
        SceneManager.LoadScene("YouLose");
    }

    public void WinGame()
    {
        SceneManager.LoadScene("YouWin");
    }

}
