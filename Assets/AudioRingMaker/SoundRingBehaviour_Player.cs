using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class SoundRingBehaviour_Player : MonoBehaviour
{

    public GameObject Player;

    void Start()
    {
        Player.GetComponent<AudioSource>().enabled = false;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W) && Player.GetComponent<AudioSource>().enabled == false)
        {

            Debug.Log("O");

            Player.GetComponent<AudioSource>().enabled = true;

        }


        if ( Input.GetKey(KeyCode.A) && Player.GetComponent<AudioSource>().enabled == false)
        {

            Debug.Log("O");

            Player.GetComponent<AudioSource>().enabled = true;

        }

        if (Input.GetKey(KeyCode.S) && Player.GetComponent<AudioSource>().enabled == false)
        {

            Debug.Log("O");

            Player.GetComponent<AudioSource>().enabled = true;

        }

        if (Input.GetKey(KeyCode.D) && Player.GetComponent<AudioSource>().enabled == false)
        {

            Debug.Log("O");

            Player.GetComponent<AudioSource>().enabled = true;

        }


        if (Input.GetKeyUp(KeyCode.W) && Player.GetComponent<AudioSource>().enabled == true)
        {
            Debug.Log("L");

            Player.GetComponent<AudioSource>().enabled = false;

        }

        if (Input.GetKey(KeyCode.A) && Player.GetComponent<AudioSource>().enabled == true)
        {
            Debug.Log("L");

            Player.GetComponent<AudioSource>().enabled = false;

        }

        if (Input.GetKey(KeyCode.S) && Player.GetComponent<AudioSource>().enabled == true)
        {
            Debug.Log("L");

            Player.GetComponent<AudioSource>().enabled = false;

        }

        if (Input.GetKey(KeyCode.D) && Player.GetComponent<AudioSource>().enabled == true)
        {
            Debug.Log("L");

            Player.GetComponent<AudioSource>().enabled = false;

        }


    }

}
