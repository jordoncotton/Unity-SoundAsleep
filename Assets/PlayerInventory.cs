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

            playerMaster.EventInventoryChanged += UpdateInventoryListAndUI;
            playerMaster.EventInventoryChanged += CheckIfHandsEmpty;
            playerMaster.EventHandsEmpty += ClearHands;
        }

        void OnDisable()
        {
            playerMaster.EventInventoryChanged -= UpdateInventoryListAndUI;
            playerMaster.EventInventoryChanged -= CheckIfHandsEmpty;
            playerMaster.EventHandsEmpty -= ClearHands;
        }

        void SetInitialReferences()
        {
            inventoryUIScript = GameObject.Find("GameManager").GetComponent<GameManagerToggleInventoryUI>();
            playerMaster = GetComponent<PlayerMaster>();
        }

        void UpdateInventoryListAndUI()
        {
            counter = 0;
            listInventory.Clear();
            listInventory.TrimExcess();

            ClearInventoryUI();

            foreach (Transform child in inventoryPlayerParent)
            {
                if (child.CompareTag("Item"))
                {
                    listInventory.Add(child);
                    GameObject go = Instantiate(uiButton) as GameObject;
                    buttonText = child.name;
                    go.GetComponentInChildren<Text>().text = buttonText;
                    int index = counter;
                    go.GetComponent<Button>().onClick.AddListener(delegate { ActiveInventoryItem(index); });
                    go.GetComponent<Button>().onClick.AddListener(inventoryUIScript.ToggleInventoryUI);
                    go.transform.SetParent(inventoryUIParent, false);
                    counter++;
                }
            }
        }

        void CheckIfHandsEmpty()
        {
            //if (currentlyHeldItem == null && listInventory.Count > 0)
            //{
            //    StartCoroutine(PlaceItemInHands(listInventory[listInventory.Count - 1]));
            //}
        }

        void ClearHands()
        {
            currentlyHeldItem = null;
        }

        void ClearInventoryUI()
        {
            foreach (Transform child in inventoryUIParent)
            {
                Destroy(child.gameObject);
            }
        }

        public void ActiveInventoryItem(int inventoryIndex)
        {
            DeactiveAllInventoryItems();
            //StartCoroutine(PlaceItemInHands(listInventory[inventoryIndex]));
        }

        void DeactiveAllInventoryItems()
        {
            foreach (Transform child in inventoryPlayerParent)
            {
                if (child.CompareTag("Item"))
                {
                    child.gameObject.SetActive(false);
                }
            }
        }

        IEnumerator PlaceItemInHands(Transform itemTransform)
        {
            yield return new WaitForSeconds(timeToPlaceInHands);
            currentlyHeldItem = itemTransform;
            currentlyHeldItem.gameObject.SetActive(true);
        }
    }

}
