﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathHandler : MonoBehaviour
{
    [SerializeField] Canvas gameOverCanvas;


    private void Start()
    {
        gameOverCanvas.enabled = false;
    }

    public void ProcessDeath()
    {
        //pause the game state
        gameOverCanvas.enabled = true;
    }
}
