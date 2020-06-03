using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MonsterBehaviour3 : MonoBehaviour
{
    public float speed = 2f;
    public float speed2 = 5f;
    public GameObject[] Waypoint;
    public float searchTime = 5f;
    public float patrolTime;

    private NavMeshAgent nav;
    private int curntPoint = 0;

    void Awake()
    {
        nav = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if (Waypoint.Length == curntPoint)
        {
            Searching();
        }

        else
        Patrolling();
    }

    void Patrolling()
    {
        nav.speed = speed;

        nav.destination = Waypoint[curntPoint].transform.position;

        if (curntPoint == Waypoint.Length-1)
        {
            curntPoint = 0;
        }

        else
        {
            curntPoint++;
        }
    }

    void Searching()
    {
        searchTime += Time.deltaTime;

        if (searchTime > patrolTime)
        {
            searchTime = 0f;
        }
    }
}
