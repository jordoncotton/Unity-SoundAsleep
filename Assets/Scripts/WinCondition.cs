﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCondition : MonoBehaviour
{
    void OnTriggerEnter()
    {
        Detection.instance.Win();
    }
}
