using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance = null;

    void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        
        else if(instance != null)
        {
            Destroy(gameObject);
        }
    }

    public void CollectItem(int passedValue, GameObject passedObject)
    {
        passedObject.GetComponent<Renderer>().enabled = false;
        Destroy(passedObject, 5.0f);
    }
}
