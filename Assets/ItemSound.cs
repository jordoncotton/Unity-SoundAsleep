using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cotton
{
    public class ItemSound : MonoBehaviour
    {
        private ItemMaster itemMaster;
        public float defaultVolume;
        public AudioClip throwSound;

        private void OnEnable()
        {
            SetInitialReferences();
            itemMaster.EventObjectPickup += PlayThrowSound;
        }

        private void OnDisable()
        {
            itemMaster.EventObjectPickup -= PlayThrowSound;
        }

        void SetInitialReferences()
        {
            itemMaster = GetComponent<ItemMaster>();
        }

        void PlayThrowSound()
        {
            if (throwSound != null)
            {
                AudioSource.PlayClipAtPoint(throwSound, transform.position, defaultVolume);

            }
        }
    }
}

