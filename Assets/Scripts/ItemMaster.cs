using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cotton
{
    public class ItemMaster : MonoBehaviour
    {
        private PlayerMaster playerMaster;

        public delegate void GeneralEventHandler();
        public event GeneralEventHandler EventObjectThrow;
        public event GeneralEventHandler EventObjectPickup;

        public delegate void PickupActionEventHandler(Transform item);    
        public event PickupActionEventHandler EventPickupAction;

        void OnEnable()
        {
            SetInitialReferences();
        }

        public void CallEventObjectThrow()
        {
            if(EventObjectThrow != null)
            {
                EventObjectThrow();
            }
            playerMaster.CallEventHandsEmpty();
            playerMaster.CallEventInventoryChanged();
        }

        public void CallEventObjectPickup()
        {
            if (EventObjectPickup != null)
            {
                EventObjectPickup();
                
            }
            playerMaster.CallEventInventoryChanged();
        }

        public void CallEventPickupAction(Transform item)
        {
            if(EventPickupAction != null)
            {
                EventPickupAction(item);
            }
        }

        void SetInitialReferences()
        {
            if (GameManagerReferences._player != null)
            {
                playerMaster = GameManagerReferences._player.GetComponent<PlayerMaster>();
            }
        }
    }
}

