using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Cotton
{
    public class PlayerInventory : MonoBehaviour
    {
        public Transform inventoryPlayerParent;
        public Transform inventoryUIParent;
        public GameObject uiButton;

        private PlayerMaster playerMaster;
        private GameManagerToggleInventoryUI inventoryUIScript;
        private float timeToPlaceInHands = 0.1f;
        private Transform currentlyHeldItem;
        private int counter;
        private string buttonText;
        private List<Transform> listInventory = new List<Transform>();

        void OnEnable()
        {
            SetInitialReferences();
            UpdateInventoryListAndUI();
            CheckIfHandsEmpty();
        }

        void OnDisable()
        {
            
        }

        void SetInitialReferences()
        {
            inventoryUIScript = GameObject.Find("GameManager").GetComponent<GameManagerToggleInventoryUI>();
            playerMaster = GetComponent<PlayerMaster>();
        }

        void UpdateInventoryListAndUI()
        {

        }

        void CheckIfHandsEmpty()
        {

        }

        void ClearHands()
        {

        }

        void ClearInventoryUI()
        {

        }

        public void ActiveInventoryItem(int inventoryIndex)
        {

        }

        void DeactiveAllInventoryItems()
        {

        }

        IEnumerator PlaceItemInHands(Transform itemTransform)
        {
            yield return new WaitForSeconds(timeToPlaceInHands);
        }
    }
}

