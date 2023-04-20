using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeOut : MonoBehaviour
{
    [SerializeField] private CanvasGroup UIGroup;
    [SerializeField] private bool fadeOut = false;
    [SerializeField] private bool fadeIn = false;

    public void ShowUI()
    {
        fadeIn = true;
    }


    public void HideUI()
    {
        fadeOut = true; 
    }

    private void Update()
    {
        if (fadeIn)
        {
            if (UIGroup.alpha < 1)
            {
                UIGroup.alpha += Time.deltaTime;
                if (UIGroup.alpha >= 1)
                {
                    fadeIn = false; 
                }
            }
        }
        if (fadeOut)
        {
            if (UIGroup.alpha >= 0)
            {
                UIGroup.alpha -= Time.deltaTime;
                if (UIGroup.alpha == 0)
                {
                    fadeOut = false; 
                }
            }
        }
    }
}
