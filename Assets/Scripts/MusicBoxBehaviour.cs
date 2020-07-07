using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicBoxBehaviour : MonoBehaviour
{

    public Animation MB;

    public bool IsPlaying;

    public AudioSource MBMusic;

    // Start is called before the first frame update
    void Start()
    {
        MBMusic.enabled = false;

        IsPlaying = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            MBMusic.enabled = true;

            IsPlaying = true;
        }

        if (IsPlaying == true)
        {
            MB.Play();
        }
    }
}
