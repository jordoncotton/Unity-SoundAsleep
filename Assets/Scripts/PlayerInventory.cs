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
        //private int counter string buttonText;
    }
}

