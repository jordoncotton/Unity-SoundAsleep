﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cotton
{
    public class TestGameOver : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
            if(Input.GetKeyUp(KeyCode.O))
            {
                GetComponent<GameManagerMaster>().CallEventGameOver();
            }
        }
    }

}
