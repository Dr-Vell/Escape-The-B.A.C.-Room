using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy_Chase : MonoBehaviour
{
    public NavMeshAgent enemy;
    public Transform player;


    // Update is called once per frame
    void Update()
    {
        enemy.SetDestination(player.position);
    }
}
