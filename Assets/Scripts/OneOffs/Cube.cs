using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{

    public Rigidbody cubeRB;
    // Start is called before the first frame update
    void Start()
    {
        cubeRB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("l");

        if (other.gameObject.tag == "ThrowArc" && cubeRB.isKinematic == false)
        {
            cubeRB.isKinematic = true;
        }
    }
}