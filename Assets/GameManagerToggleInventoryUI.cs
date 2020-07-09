using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Cotton
{
    public class GameManagerToggleInventoryUI : MonoBehaviour
    {
        [Tooltip("Does this game have an Inventory? Set to true if that is true")]
        public bool hasInventory;
        public GameObject inventoryUI;
        public string toggleInventoryButton;
        private GameManagerMaster gameManagerMaster;

        void Start()
        {
            SetInitialReferences();
        }

        void Update()
        {
            CheckForInventoryUIToggleRequest();
        }

        void SetInitialReferences()
        {
            gameManagerMaster = GetComponent<GameManagerMaster>();

            if (toggleInventoryButton == "")
            {
                Debug.LogWarning("Please type in the name of the button used to toggle the Inventory in gameManager" +
                    "GamemanagerToggleInventoryUI");
                this.enabled = false;
            }
        }

        void CheckForInventoryUIToggleRequest()
        {
            if (Input.GetButtonUp(toggleInventoryButton) && !gameManagerMaster.isMenuOn &&
                !gameManagerMaster.isGameOver && hasInventory)
            {
                ToggleInventoryUI();
            }
        }

        public void ToggleInventoryUI()
        {
            if (inventoryUI != null)
            {
                inventoryUI.SetActive(!inventoryUI.activeSelf);
                gameManagerMaster.isInventoryUIOn = !gameManagerMaster.isInventoryUIOn;
                gameManagerMaster.CallEventInventoryUIToggle();
            }
        }
    }
}

