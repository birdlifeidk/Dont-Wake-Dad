using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private GameObject gameStartMenu, _startButton;
    [SerializeField] private TextMeshProUGUI _stateText;

    private void Awake()
    {
        GameManager.OnGameStateChanged += GameManagerGameStateChanged;
    }

    private void OnDestroy()
    {
        GameManager.OnGameStateChanged -= GameManagerGameStateChanged;
    }

    private void GameManagerGameStateChanged(GameManager.GameState obj)
    {
        throw new System.NotImplementedException();
    }

    private void Start()
    {
        
    }
    
}
