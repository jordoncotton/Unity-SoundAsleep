using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;
using UnityEngine.AI;

public class MonsterBehaviour4 : MonoBehaviour
{
    public GameObject Banshee;

    public GameObject[] Waypoint;

    private int curntPoint = 0;

    private NavMeshAgent agent;

    public bool Pathfinding;

    public Vector3 Ref;

    public bool isAni;

    private float AniTime;

    public Animator animator;

    public float walkSpeed;

    public float runSpeed;

    public float idelTimer;

    public bool Running;


    public AudioSource walker;
    public AudioSource runner;

    public AudioSource Crying;

    public GameObject gameOver;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();

        agent.autoBraking = false;

        Pathfinding = true;

        NextPoint();

        Ref = new Vector3(0.0f, 0.0f, 0.0f);

        Running = false;

        isAni = false;

        walkSpeed = 0.3f; 

        runSpeed = 3.5f;

        idelTimer = 0;

        agent.speed = walkSpeed;

        walker.enabled = true;

        runner.enabled = false;

        Crying.enabled = false;

        gameOver.SetActive(false);
    }

    void NextPoint()
    {
        if (Waypoint.Length == 0)
        {
            return;
        }

        agent.destination = Waypoint[curntPoint].transform.position;

        curntPoint = (curntPoint + 1) % Waypoint.Length;
    }
    // Update is called once per frame
    void Update()
    {


        if (isAni == false)
        {
            AniTime = (1.0f);
        }
        if (Pathfinding == false)
        {
            agent.destination = Ref;

            if (!agent.pathPending && agent.remainingDistance < 2)
            {

                isAni = true;

                if(isAni== true)
                {
                    AniTime -= Time.deltaTime;

                    if(AniTime <= 0.0f)
                    {
                        isAni = false;

                        Pathfinding = true;
                    }

                }
                
            }
        }
        if (Pathfinding == true)
        {
            if (!agent.pathPending && agent.remainingDistance < 2)
            {
                isAni = true;

                if(isAni == true)
                {

                    Running = false;
                    AniTime -= Time.deltaTime;

                    if(AniTime <= 0.0f)
                    {
                        isAni = false;

                        NextPoint();
                    }

                }
                
            }
        }

        animator.SetFloat("Speed", agent.velocity.magnitude / runSpeed);

        if (idelTimer > 0.0f)
        {
            idelTimer = idelTimer - Time.deltaTime;


            agent.speed = 0.0f;
        }

        if (idelTimer <= 0.0f && Pathfinding == false)
        {
            idelTimer = 0.0f;

            agent.speed = runSpeed;

            Crying.enabled = false;

            walker.enabled = false;

            runner.enabled = true;
        }

        if (idelTimer <= 0.0f && Pathfinding == true)
        {
            idelTimer = 0.0f;

            agent.speed = walkSpeed;

            Crying.enabled = false;

            walker.enabled = true;

            runner.enabled = false;

        }


    }

    public void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("SOUND"))
        {

            Pathfinding = false;

            Ref = collider.gameObject.transform.position;

            Running = true;

            idelTimer = 2.458f;

            animator.SetTrigger("Alerted");

            Crying.enabled = true;
        }

        if (collider.gameObject.CompareTag("Player"))
        {
            animator.SetTrigger("Attack");

            idelTimer = 1.417f;

            gameOver.SetActive(true);
        }
      
        Debug.Log("N");
    }


}
