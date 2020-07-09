using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cotton
{
    public class GameManagerToggleMenu : MonoBehaviour
    {
        private GameManagerMaster gameManagerMaster;
        public GameObject menu;

        private void Start()
        {
            ToggleMenu();
        }

        void Update()
        {
            CheckForMenuToggleRequest();
        }

        void OnEnable()
        {
            SetInitialReferences();
            gameManagerMaster.GameOverEvent += ToggleMenu;
        }

        void OnDisable()
        {
            gameManagerMaster.GameOverEvent -= ToggleMenu;
        }

        void SetInitialReferences()
        {
            gameManagerMaster = GetComponent<GameManagerMaster>();
        }

        void CheckForMenuToggleRequest()
        {
            if (Input.GetKeyUp(KeyCode.Escape) && !gameManagerMaster.isGameOver && !gameManagerMaster.isInventoryUIOn)
            {
                ToggleMenu();
            }
        }

        void ToggleMenu()
        {
            if (menu != null)
            {
                menu.SetActive(!menu.activeSelf);
                gameManagerMaster.isMenuOn = !gameManagerMaster.isMenuOn;
                gameManagerMaster.CallEventMenuToggle();
            }
            else
            {
                Debug.LogWarning("You need to assign a UI GameObject to the Toggle Menu script in the inspector");
            }
        }
    }
}

