using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Cotton
{
    public class EnemyMaster : MonoBehaviour
    {
        public Transform myTarget;

        public bool isOnRoute;

        public delegate void GeneralEventHandler();
        public event GeneralEventHandler EventEnemyAttack;
        public event GeneralEventHandler EventEnemyReachedNavTarget;

        public delegate void HealthEventHandler(int health);
        public event HealthEventHandler EventEnemyDeductHealth;

        public delegate void NavTargetEventHandler(Transform targetTransform);
        public event NavTargetEventHandler EventEnemySetNavTarget;

        public void CallEventEnemyHealthDeduction(int health)
        {
            if (EventEnemyDeductHealth != null)
            {
                EventEnemyDeductHealth(health);
            }
        }

        public void CallEventEnemySetNavTarget(Transform targTransform)
        {
            if (EventEnemySetNavTarget != null)
            {
                EventEnemySetNavTarget(targTransform);
            }
            myTarget = targTransform;
        }

        public void CallEventEnemyReachedNavTarget()
        {
            if (EventEnemyReachedNavTarget != null)
            {
                EventEnemyReachedNavTarget();
            }
        }

        public void CallEventEnemyAttack()
        {
            if (EventEnemyAttack != null)
            {
                EventEnemyAttack();
            }
        }
    }
}

