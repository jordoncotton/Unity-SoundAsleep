using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace Cotton
{
    public class PlayerHealth : MonoBehaviour
    {
        private GameManagerMaster gameManagerMaster;
        private PlayerMaster playerMaster;
        public int playerHealth;

        void OnEnable()
        {
            SetInitialReferences();
            playerMaster.EventPlayerHealthDeduction += DeductHealth;
        }

        void OnDisable()
        {
            playerMaster.EventPlayerHealthDeduction -= DeductHealth;
        }
        void Start()
        {
            StartCoroutine(TestHealthDeduction());
        }

        void SetInitialReferences()
        {
            gameManagerMaster = GameObject.Find("GameManager").GetComponent<GameManagerMaster>();
            playerMaster = GetComponent<PlayerMaster>();
        }

        IEnumerator TestHealthDeduction()
        {
            yield return new WaitForSeconds(2);
            //DeductHealth(100);
            playerMaster.CallEventPlayerHealthDeduction(50);
        }

        void DeductHealth(int healthChange)
        {
            playerHealth += healthChange;

            if (playerHealth > 100)
            {
                playerHealth = 100;
                gameManagerMaster.CallEventGameOver();
            }
        }
    }
}

