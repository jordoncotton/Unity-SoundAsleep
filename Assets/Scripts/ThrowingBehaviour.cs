using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowingBehaviour : MonoBehaviour
{
    private GameObject heldObj = null;

    private Rigidbody heldObjRB = null;

    //public GameObject ball;

    //public GameObject cube;

    //public GameObject ballholdr;

    //public GameObject cubeholdr;

    //public GameObject player;

    //public Rigidbody ballRB;

    //public Rigidbody cubeRB;

    //public bool isHolding;

    //public bool BallThrown;

    //public bool CubeThrown;

   // // public Mesh ballMsh;

   // public Mesh cubeMsh;
    // Start is called before the first frame update
    void Start()
    {
        //ball.SetActive(false);

        //cube.SetActive(false);

        ////ballMsh = false;


        //ballRB = ball.GetComponent<Rigidbody>();

        //cubeRB = cube.GetComponent<Rigidbody>();

        //ballRB.isKinematic = true;

        //cubeRB.isKinematic = true;

        //isHolding = false;

        //BallThrown = true;

        //CubeThrown = true;
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyDown(KeyCode.Space) && heldObj != null)
        {
            heldObj.transform.parent = null;

            heldObjRB.isKinematic = false;
            heldObjRB.AddForce(new Vector3(4, 4, 0), ForceMode.Impulse);
            heldObj = null;
        }

        //if(Input.GetKeyDown(KeyCode.Space) && ballholdr.activeInHierarchy == false && BallThrown == false)
        //{
        //    ball.transform.parent = null;
        //    ballRB.isKinematic = false;
        //    //ball.transform.rotation = player.transform.rotation;
        //    ballRB.AddForce(new Vector3(4, 4, 0), ForceMode.Impulse);

        //    isHolding = false;

        //    BallThrown = true;
        //}

        //if (Input.GetKeyDown(KeyCode.Space) && cubeholdr.activeInHierarchy == false && CubeThrown == false)
        //{

        //    cube.transform.parent = null;
        //    cubeRB.isKinematic = false;
        //    //cube.transform.rotation = player.transform.rotation;
        //    cubeRB.AddForce(new Vector3(4, 4, 0), ForceMode.Impulse);

        //    isHolding = false;

        //    CubeThrown = true;
        //}

    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("p");

        if(heldObj == null)
        {
            ThrowablePropertiesBehaviour throwableProperties = other.gameObject.GetComponent<ThrowablePropertiesBehaviour>();
            if (throwableProperties != null)
            {
                other.gameObject.SetActive(false);

                heldObj = throwableProperties.heldObj;

                heldObj.SetActive(true);

                heldObjRB = heldObj.GetComponent<Rigidbody>();
                heldObjRB.isKinematic = true;


            }
        }
        //if(other.gameObject.tag == "CUBE" && isHolding == false)
        //{
        //    cubeholdr.SetActive(false);

        //    isHolding = true;

        //    cube.SetActive(true);

        //    CubeThrown = false;

        //}

        //if (other.gameObject.tag == "BALL" && isHolding == false)
        //{
        //    ballholdr.SetActive(false);

        //    isHolding = true;

        //    ball.SetActive(true);

        //    BallThrown = false;
        //}
    }
}