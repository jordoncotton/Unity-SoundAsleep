using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpactBehaviour : MonoBehaviour
{

    public AudioSource impact;

    public float Duration;
    // Start is called before the first frame update
    void Start()
    {
        impact.enabled = false;

        Duration = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        Duration = Duration - Time.deltaTime;

        if(Duration <= 0.0f)
        {
            impact.enabled = false;
        }



    }

    void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.CompareTag("Ground"))
        {
            Debug.Log("Q");
            impact.enabled = true;

            Duration = 3.0f;
        }
    }
}
