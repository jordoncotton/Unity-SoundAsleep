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
        if (Input.GetKey(KeyCode.W)|| Input.GetKey(KeyCode.A)|| Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {

            Debug.Log("O");

            Player.GetComponent<AudioSource>().enabled = true;

        }

        if (Input.GetKeyUp(KeyCode.W) || Input.GetKey(KeyCode.A)|| Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            Debug.Log("L");

            Player.GetComponent<AudioSource>().enabled = false;

        }

    }

}
