using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitHealth : MonoBehaviour
{
    [SerializeField] private int health = 10;

    [SerializeField] private PlayerManager manager;

    public void SetManager(PlayerManager newManager)
    {
        manager = newManager;
    }

    public void TakeDamage(int damage)
    {
        health -= damage;

        if(health <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        manager.KillUnit(this);
        //Destroy(gameObject);
    }
}
