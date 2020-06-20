using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class MonsterBehaviour4 : MonoBehaviour
{
    public Material MonstBody;

    public Material MonstDress;

    public Material MonstHair;

    public GameObject[] Waypoint;

    private int curntPoint = 0;

    private NavMeshAgent agent;

    public bool Pathfinding;

    public Vector3 Ref;

    public bool isAni;

    public float Diss;

    private float AniTime;


    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();

        agent.autoBraking = false;

        Pathfinding = true;

        NextPoint();

        Ref = new Vector3(0.0f, 0.0f, 0.0f);

        Diss = 0.8f;

        isAni = false;

        MonstBody.SetFloat("_Dissolve", Diss);

        MonstDress.SetFloat("_Dissolve", Diss);

        MonstHair.SetFloat("_Dissolve", Diss);



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

                if (Diss > 0.0f)
                {
                Diss--;
                }
            {

            }

        }
        if (Pathfinding == true)
        {
            if (!agent.pathPending && agent.remainingDistance < 2)
            {
                isAni = true;

                if(isAni == true)
                {
                    AniTime -= Time.deltaTime;

                    if(AniTime <= 0.0f)
                    {
                        isAni = false;

                        NextPoint();
                    }

                }
                
            }

            if (Diss < 0.8f)
            {
                Diss++;
            }

        }
    }

    public void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("SOUND"))
        {

            Pathfinding = false;

            Ref = collider.gameObject.transform.position;
        }

        //Debug.Log("N");

        if(collider.gameObject.CompareTag("Player"))
        {
            MonstBody.SetFloat("_Dissolve", 0.0f);

            MonstDress.SetFloat("_Dissolve", 0.8f);


            SceneManager.LoadScene(2);

            Debug.Log("N");
        }
    }

}
