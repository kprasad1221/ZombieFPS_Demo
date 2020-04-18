using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] float healthPoints = 100f;

    public void TakeDamage(float damage)
    {
        healthPoints -= damage;
        if(healthPoints <= 0f)
        {
            GetComponent<DeathHandler>().ProcessDeath();
        }
    }
}
