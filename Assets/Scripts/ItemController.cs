using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour
{
    public GameObject Throw;

    public float speed = 1000f;

    int ThrowCount = 0;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            ThrowCount++;
        }
    }

    void ThrowItem()
    {
        if(ThrowCount > 0)
        {
            ThrowCount--;
            GameObject go = (GameObject)Instantiate(Throw, transform.position, Quaternion.identity);
            ThrowObject to = go.GetComponent<ThrowObject>();
            to.Throw(transform.forward * speed);
        }
    }

    private void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "Item")
        {
            ThrowCount++;
            Destroy(col.gameObject);
        }
    }
}
