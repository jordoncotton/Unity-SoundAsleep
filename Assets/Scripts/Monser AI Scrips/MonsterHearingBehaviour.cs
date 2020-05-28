using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MonsterHearingBehaviour : MonoBehaviour
{

    public bool playerKnown;
    public Vector3 LocationHeard;

    private NavMeshAgent nav;
    private CapsuleCollider capsuleCollider;
    private Animator animator;
    private GameObject player;
    private Vector3 PreviouslyKnownLocation;


    void Awake()
    {
        nav = GetComponent<NavMeshAgent>();
        capsuleCollider = GetComponent<CapsuleCollider>();
        animator = GetComponent<Animator>();
        //player = GameObject.FindGameObjectsWithTag("Player");
        
        //LocationHeard = 
    }

    void Update()
    {

    }
}
