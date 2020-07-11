using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Cotton
{
    public class GameManagerGameOver : MonoBehaviour
    {
        private GameManagerMaster gameManagerMaster;
        public GameObject panelGameOver;

        private void OnEnable()
        {
            SetInitialReferences();
            gameManagerMaster.GameOverEvent += TurnOnGameOverPanel;
        }

        private void OnDisable()
        {
            gameManagerMaster.GameOverEvent -= TurnOnGameOverPanel;
        }

        void SetInitialReferences()
        {
            gameManagerMaster = GetComponent<GameManagerMaster>();
        }

        void TurnOnGameOverPanel()
        {
            if (panelGameOver != null)
            {
                panelGameOver.SetActive(true);
            }
        }
    }
}

