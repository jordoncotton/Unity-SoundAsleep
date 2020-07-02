using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayOnClick : MonoBehaviour
{
    public AudioSource Sound;
    public float coolDownTimer;
    public float sound = 10;

    // Update is called once per frame
    void Update()
    {
        if (coolDownTimer > 0)
        {
            coolDownTimer -= Time.deltaTime;
        }

        if (coolDownTimer < 0)
        {
            coolDownTimer = 0;
        }

        if (Input.GetKeyDown(KeyCode.F) && coolDownTimer == 0)
        {
            Sound.Play();
            coolDownTimer = sound;
        }
    }
}
