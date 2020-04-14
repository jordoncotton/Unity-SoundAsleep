using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractBehaviour : MonoBehaviour
{
    public bool isActing;

    void start()
    {
        isActing = false;
    }

    void update()
    {
        if(isActing == true)
        {
            transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
        }
    }
    public void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Monster") && isActing == false)
        {
            isActing = true;
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
