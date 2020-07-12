using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MementosSoundEffectBehaviour : MonoBehaviour
{

    public AudioSource blanket;

    public AudioSource picture;

    public AudioSource Snowglobe;

    public AudioSource TeddyBear;

    public GameObject MemBlanket;

    public GameObject MemPicture;

    public GameObject MemGlobe;

    public GameObject MemBear;

    // Start is called before the first frame update
    void Start()
    {
        blanket.enabled = false; 

        picture.enabled = false;

        Snowglobe.enabled = false;

        TeddyBear.enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
        if(MemBlanket.GetComponent<MeshRenderer>().enabled == false)
        {
            blanket.enabled = true;
        }

        if (MemPicture.GetComponent<MeshRenderer>().enabled == false)
        {
            picture.enabled = true;
        }

        if (MemGlobe.GetComponent<MeshRenderer>().enabled == false)
        {
            Snowglobe.enabled = true;
        }

        if (MemBear.GetComponent<MeshRenderer>().enabled == false)
        {
            TeddyBear.enabled = true;
        }

    }
}
