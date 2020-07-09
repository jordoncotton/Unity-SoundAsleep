using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Cotton
{
    public class ItemPickup : MonoBehaviour
    {
        private ItemMaster itemMaster;
        public static SoundManager instance = null;
        public int value;

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

        public void CollectItem(int passedValue, GameObject passedObject)
        {
            passedObject.GetComponent<Renderer>().enabled = false;
        }

        public void CarryOutPickupActions(Transform tParent)
        {
            transform.SetParent(tParent);
            itemMaster.CallEventObjectPickup();
            transform.gameObject.SetActive(false);
            SoundManager.instance.CollectItem(value, gameObject);

            AudioSource source = GetComponent<AudioSource>();
            source.Play();
        }
    }
}

