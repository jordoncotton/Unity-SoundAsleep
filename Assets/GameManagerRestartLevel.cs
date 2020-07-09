using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Cotton
{
    public class GameManagerRestartLevel : MonoBehaviour
    {
        private GameManagerMaster gameManagerMaster;

        void OnEnable()
        {
            SetInitialReferences();
            gameManagerMaster.RestartLevelEvent += RestartLevel;
        }


        void OnDisable()
        {
            gameManagerMaster.RestartLevelEvent -= RestartLevel;
        }

        void SetInitialReferences()
        {
            gameManagerMaster = GetComponent<GameManagerMaster>();
        }

        void RestartLevel()
        {
            Application.LoadLevel(Application.loadedLevel);
        }
    }
}

