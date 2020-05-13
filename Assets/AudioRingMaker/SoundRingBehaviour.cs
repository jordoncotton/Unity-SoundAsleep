using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class SoundRingBehaviour : MonoBehaviour
{

    public AudioSource SoundSorc;

    public GameObject SoundRing;

    public GameObject bubble;

    public GameObject AttachmentObj;

    public int Echo;
    //number by which we will multiply the volume to get the size of the sound ring

    Vector3 RingSize;

    Vector3 RingPosition;

    Vector3 bubbleSize;

   // Vector3 bubblePos;

    public float expand;

    public bool expandable;

    void hold()
    {

    }

    void Start()
    {
        bubbleSize = new Vector3(0, 0, 0);

        expand = 0.0f;
    }

    void Update()
    {

        SoundRing.transform.localScale = RingSize;

        SoundRing.transform.position = RingPosition;

        bubble.transform.localScale = bubbleSize;

        //bubble.transform.position = bubblePos;

        RingSize = new Vector3(Echo  * SoundSorc.volume, 0.1f, Echo *  SoundSorc.volume);

        bubbleSize = new Vector3(expand, expand, expand);


        RingPosition = AttachmentObj.transform.position;


        if (SoundSorc.enabled == true)
        {
            SoundRing.SetActive(true);

            expandable = true;

        }

        if (SoundSorc.enabled == false)
        {
            SoundRing.SetActive(false);

            expandable = false;
        }

        if(expandable == true)
        {
            expand = expand + Time.deltaTime * 7;

            if(expand >= RingSize.x)
            {
                expand = 0.0f;
            }
        }
        

    }
}
