using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    [SerializeField] private int damage = 1;

    private void OnTriggerStay(Collider collider)
    {
        if(collider.transform.tag == "Player")
        {
            collider.transform.GetComponent<UnitHealth>().TakeDamage(damage);
        }
    }
}