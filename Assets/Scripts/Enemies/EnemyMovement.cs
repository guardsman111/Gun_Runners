using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private PlayerLocator playerLocator;

    [SerializeField] private float speedModifier = 1;

    void Start()
    {
        if(playerLocator == null)
        {
            playerLocator = FindObjectOfType<PlayerLocator>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(transform.position, playerLocator.transform.position) < 10)
        {
            transform.LookAt(playerLocator.transform);
            transform.position = Vector3.MoveTowards(transform.position, playerLocator.transform.position, speedModifier * Time.deltaTime);
        }
    }
}
