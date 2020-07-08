using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicBoxBehaviour : MonoBehaviour
{

   // public Animation MB;

    public Animator MBAni;

    //public bool IsPlaying;

    public AudioSource MBMusic;

    public GameObject Box;

    // Start is called before the first frame update
    void Start()
    {
        MBMusic.enabled = false;

        MBAni.enabled = false;
        //IsPlaying = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            MBMusic.enabled = true;

            MBAni.enabled = true;
           // IsPlaying = true;
        }

        if (Input.GetKeyUp(KeyCode.F))
        {
            MBMusic.enabled = false;

            MBAni.enabled = false;

            //IsPlaying = true;
        }


        //if (IsPlaying == true)
        //{
        //    //MB.Play();
        //}
    }
}
