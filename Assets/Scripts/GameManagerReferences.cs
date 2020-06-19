using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Cotton
{
    public class GameManagerReferences : MonoBehaviour
    {
        public string playerTag;
        public static string _playerTag;

        public string enemyTag;
        public static string _enemyTag;

        public static GameObject _player;

        void OnEnable()
        {
            if(playerTag == "")
            {
                Debug.LogWarning("Please type in the name of the player tag in the GamemangerReferences" +
                    "slot in the inspector or else the Cotton Systems will not work");
            }

            if (enemyTag == "")
            {
                Debug.LogWarning("Please type in the name of the enemy tag in the GamemangerReferences" +
                    "slot in the inspector or else the Cotton Systems will not work");
            }

            _playerTag = playerTag;
            enemyTag = _enemyTag;

            _player = GameObject.FindGameObjectWithTag(_playerTag);
        }
    }
}

