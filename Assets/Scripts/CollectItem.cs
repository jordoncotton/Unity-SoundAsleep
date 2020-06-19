using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectItem : MonoBehaviour
{
    public int value;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter()
    {
        SoundManager.instance.CollectItem(value, gameObject);

        AudioSource source = GetComponent<AudioSource>();
        source.Play();
    }
}
