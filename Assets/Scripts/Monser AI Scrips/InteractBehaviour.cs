using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractBehaviour : MonoBehaviour
{
    public bool isActing /*= false*/;

    void Start()
    {
        isActing = true;
    }

    void Update()
    {
        if(isActing == true)
        {
            transform.Rotate(new Vector3 (15, 30, 45) * Time.deltaTime);
        }
    }
    public void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Monster") && isActing == false)
        {
            isActing = true;

            Debug.Log("n");
        }

        if (collider.gameObject.CompareTag("Monster") && isActing == true)
        {
            isActing = false;

        }

        if (collider.gameObject.CompareTag("Player") && isActing == false && Input.GetKey(KeyCode.F))
        {
            isActing = true;
        }

        if (collider.gameObject.CompareTag("Player") && isActing == true && Input.GetKey(KeyCode.F))
        {
            isActing = false;
        }

        Debug.Log("L");
    }
}
