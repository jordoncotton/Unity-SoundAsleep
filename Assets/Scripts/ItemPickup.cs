using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cotton
{
    public class ItemPickup : MonoBehaviour
    {
        private ItemMaster itemMaster;

        void OnEnable()
        {
            SetInitialReferences();
            itemMaster.EventPickupAction += CarryOutPickupActions;
        }

        void OnDisable()
        {
            itemMaster.EventPickupAction -= CarryOutPickupActions;
        }

        void SetInitialReferences()
        {
            itemMaster = GetComponent<ItemMaster>();
        }

        void CarryOutPickupActions(Transform tParent)
        {
            transform.SetParent(tParent);
            itemMaster.CallEventObjectPickup();
            transform.gameObject.SetActive(false);
        }
    }
}

