using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cotton
{
    public class PlayerCanvasHurt : MonoBehaviour
    {
        public GameObject hurtCanvas;
        private PlayerMaster playerMaster;
        private float secondsTillHide = 2;

        void OnEnable()
        {
            SetInitialReferences();
            playerMaster.EventPlayerHealthDeduction += TurnOnHurtEffect;
        }

        void OnDisable()
        {
            playerMaster.EventPlayerHealthDeduction -= TurnOnHurtEffect;
        }

        void SetInitialReferences()
        {
            playerMaster = GetComponent<PlayerMaster>();
        }

        void TurnOnHurtEffect(int dummy)
        {
            if(hurtCanvas != null)
            {
                StopAllCoroutines();
                hurtCanvas.SetActive(true);
                StartCoroutine(ResetHurtCanvas());
            }
        }

        IEnumerator ResetHurtCanvas()
        {
            yield return new WaitForSeconds(secondsTillHide);
            hurtCanvas.SetActive(false);
        }
    }
}

