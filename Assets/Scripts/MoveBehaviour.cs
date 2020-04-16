using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBehaviour : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.A))
        {
            transform.position -= transform.TransformDirection(Vector3.left) * Time.deltaTime * 2.0f;

        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.TransformDirection(Vector3.left) * Time.deltaTime * 2.0f;
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position += transform.TransformDirection(Vector3.forward) * Time.deltaTime * 2.0f;
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.position -= transform.TransformDirection(Vector3.forward) * Time.deltaTime * 2.0f;
        }


    }
}
