using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cotton
{
    public class PlayerMaster : MonoBehaviour
    {
        public delegate void GeneralEventHandler();
        public event GeneralEventHandler EventInventoryChanged;
        public event GeneralEventHandler EventHandsEmpty;

        public delegate void PickedupEventHandler(string PickedupName, int quantity);
        public event PickedupEventHandler EventPickedup;

        public void CallEventInventoryChanged()
        {
            if (EventInventoryChanged != null)
            {
                EventInventoryChanged();
            }
        }

        public void CallEventHandsEmpty()
        {
            if (EventHandsEmpty != null)
            {
                EventHandsEmpty();
            }
        }

        public void CallEventPickedup(string PickedupName, int quantity)
        {
            if (EventPickedup != null)
            {
                EventPickedup(PickedupName, quantity);
            }
        }
    }
}

