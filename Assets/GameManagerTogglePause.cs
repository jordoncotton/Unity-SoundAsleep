using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Cotton
{
    public class GameManagerTogglePause : MonoBehaviour
    {
        private GameManagerMaster gameManagerMaster;
        private bool isPaused;
        // Start is called before the first frame update
        void OnEnable()
        {
            SetInitialReferences();
            gameManagerMaster.MenuToggleEvent += TogglePause;
            gameManagerMaster.InventoryUIToggleEvent += TogglePause;
        }

        // Update is called once per frame
        void OnDisable()
        {
            gameManagerMaster.MenuToggleEvent -= TogglePause;
            gameManagerMaster.InventoryUIToggleEvent -= TogglePause;
        }

        void SetInitialReferences()
        {
            gameManagerMaster = GetComponent<GameManagerMaster>();
        }

        void TogglePause()
        {
            if (isPaused)
            {
                Time.timeScale = 1;
                isPaused = false;
            }
            else
            {
                Time.timeScale = 0;
                isPaused = true;
            }
        }
    }
}

