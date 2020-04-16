using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractBehaviour : MonoBehaviour
{
    public bool isActing /*= false*/;

    public float Delay;

    void Start()
    {
        isActing = true;

        Delay = 0.0f;
    }

    void Update()
    {
        if(isActing == true)
        {
            transform.Rotate(new Vector3 (15, 30, 45) * Time.deltaTime);
        }

        Delay -= Time.deltaTime;
    }
    public void OnTriggerEnter(Collider collider) 
    {
        if (collider.gameObject.CompareTag("Monster") && isActing == false && Delay <= 0.0f)
        {
            isActing = true;

            Debug.Log("N");

            Delay = 2.0f;

            
        }

        if (collider.gameObject.CompareTag("Monster") && isActing == true && Delay <= 0.0f)
        {
            isActing = false;

            Debug.Log("K");

            Delay = 2.0f;

        }

        if (collider.gameObject.CompareTag("Player") && isActing == false && Delay <= 0.0f)
        {
            isActing = true;

            Debug.Log("R");

            Delay = 2.0f;

        }

        if (collider.gameObject.CompareTag("Player") && isActing == true && Delay <= 0.0f)
        {
            isActing = false;

            Debug.Log("O");

            Delay = 2.0f;

        }

      
    }
}
