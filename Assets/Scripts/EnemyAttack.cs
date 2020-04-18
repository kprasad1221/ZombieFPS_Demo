using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    PlayerHealth target;
    [SerializeField] float damage = 40f;

    void Start()
    {
        target = FindObjectOfType<PlayerHealth>();
    }

    void OnDamageTaken()
    {
        print("Message Broadcast Received");
    }

    public void AttackHitEvent()
    {
        if(target == null) { return; }
        Debug.Log("ATTACKED!");
        target.TakeDamage(damage);
    }

}
