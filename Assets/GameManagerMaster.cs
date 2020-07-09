using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Cotton
{
    public class GameManagerMaster : MonoBehaviour
    {
        public delegate void GameManagerEventHandler();
        public GameManagerEventHandler MenuToggleEvent;
        public GameManagerEventHandler InventoryUIToggleEvent;
        public GameManagerEventHandler RestartLevelEvent;
        public GameManagerEventHandler GoToMenuSceneEvent;
        public GameManagerEventHandler GameOverEvent;

        public bool isGameOver;
        public bool isInventoryUIOn;
        public bool isMenuOn;

        public void CallEventMenuToggle()
        {
            if (MenuToggleEvent != null)
            {
                MenuToggleEvent();
            }
        }

        public void CallEventInventoryUIToggle()
        {
            if (InventoryUIToggleEvent != null)
            {
                InventoryUIToggleEvent();
            }
        }

        public void CallEventRestartLevel()
        {
            if (RestartLevelEvent != null)
            {
                RestartLevelEvent();
            }
        }

        public void CallEventGoToMenuScene()
        {
            if (GoToMenuSceneEvent != null)
            {
                GoToMenuSceneEvent();
            }
        }

        public void CallEventGameOver()
        {
            if (GameOverEvent != null)
            {
                GameOverEvent();
            }
        }


        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}

