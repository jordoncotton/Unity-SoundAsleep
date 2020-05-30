using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowingBehaviour : MonoBehaviour
{
    private GameObject heldObj = null;

    private Rigidbody heldObjRB = null;


    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space) && heldObj != null)
        {
            heldObj.transform.parent = null;

            heldObjRB.isKinematic = false;
            heldObjRB.AddForce(new Vector3(4, 4, 0), ForceMode.Impulse);
            heldObj = null;
        }

    }

    void OnTriggerStay(Collider other)
    {
        //Debug.Log("p");

        if (heldObj == null)
        {
            ThrowablePropertiesBehaviour throwableProperties = other.gameObject.GetComponent<ThrowablePropertiesBehaviour>();
            if (throwableProperties != null && Input.GetKeyDown(KeyCode.E))
            {
                other.gameObject.SetActive(false);

                heldObj = throwableProperties.heldObj;

                heldObj.SetActive(true);

                heldObjRB = heldObj.GetComponent<Rigidbody>();
                heldObjRB.isKinematic = true;


            }
        }

    }
}
