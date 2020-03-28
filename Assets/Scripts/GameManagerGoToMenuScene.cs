using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Cotton
{
    public class GameManagerGoToMenuScene : MonoBehaviour
    {
        private GameManagerMaster gameManagerMaster;

        void OnEnable()
        {
            SetInitialReferences();
            gameManagerMaster.GoToMenuSceneEvent += GoToMenuScene;
        }

        void OnDisable()
        {
            gameManagerMaster.GoToMenuSceneEvent -= GoToMenuScene;
        }

        void SetInitialReferences()
        {
            gameManagerMaster = GetComponent<GameManagerMaster>();
        }

        void GoToMenuScene()
        {
            Application.LoadLevel(0);
        }
    }
}

