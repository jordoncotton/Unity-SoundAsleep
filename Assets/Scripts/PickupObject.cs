//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class PickupObject : MonoBehaviour
//{
//    GameObject mainCamera;
//    bool carrying;
//    GameObject carriedObject;
//    public float distance;
//    public float smooth;

//    void Start()
//    {
//        mainCamera = GameObject.FindWithTag("MainCamera");
//    }

//    void Update()
//    {
//        if (carrying)
//        {
//            carry(carriedObject);
//            checkDrop();
//        }
//        else
//        {
//            pickup();
//        }
//    }

//    void carry(GameObject o)
//    {
//        o.transform.position = Vector3.Lerp(o.transform.position, 
//            mainCamera.transform.position + mainCamera.transform.forward
//            * distance, Time.deltaTime * smooth);
//    }

//    void pickup()
//    {
//        if (Input.GetMouseButtonDown(1))
//        {
//            int x = Screen.width / 2;
//            int y = Screen.height / 2;

//            Ray ray = mainCamera.camera.ScreenPointToRay(new Vector3(x, y));
//            RaycastHit hit;
//            if(Physics.Raycast(ray, out hit))
//            {
//                CarryItem c = hit.collider.GetComponent<CarryItem>();
//                if(c != null)
//                {
//                    carrying = true;
//                    carriedObject = c.gameObject;
//                    c.gameObject.rigidbody.isKinematic = true;
//                }
//            }
//        }
//    }
//}
