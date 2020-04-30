using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cotton
{
    public class ItemThrow : MonoBehaviour
    {
        private ItemMaster itemMaster;
        private Transform myTransform;
        private Rigidbody myRigidbody;
        private Vector3 throwDirection;

        public bool canBeThrown;
        public string throwButtonName;
        public float throwForce;

        // Start is called before the first frame update
        void Start()
        {
            SetInitialReferences();
        }

        // Update is called once per frame
        void Update()
        {
            CheckForThrowInput();
        }

        void SetInitialReferences()
        {
            itemMaster = GetComponent<ItemMaster>();
            myTransform = transform;
            myRigidbody = GetComponent<Rigidbody>();
        }

        void CheckForThrowInput()
        {
            if(throwButtonName != null)
            {
                if(Input.GetButtonDown(throwButtonName) && Time.timeScale > 0 && canBeThrown &&
                    myTransform.root.CompareTag(GameManagerReferences._playerTag))
                {
                    CarryOutThrowActions();
                }
            }
        }

        void CarryOutThrowActions()
        {
            throwDirection = myTransform.parent.forward;
            myTransform.parent = null;
            itemMaster.CallEventObjectThrow();
            HurlItem();
        }

        void HurlItem()
        {
            myRigidbody.AddForce(throwDirection * throwForce, ForceMode.Impulse);
        }
    }
}


