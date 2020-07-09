using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cotton
{
    public class MainMenu : MonoBehaviour
    {
        public void PlayGame()
        {
            Application.LoadLevel(1);
        }

        public void ExitGame()
        {
            Application.Quit();
        }
    }
}

