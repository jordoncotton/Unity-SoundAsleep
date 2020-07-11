using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Cotton
{
    public class EnemyAttack : MonoBehaviour
    {
        private EnemyMaster enemyMaster;

        private Transform attackTarget;
        private Transform myTransform;

        public float attackRate = 1;
        public float nextAttack;
        public float attackRange = 3.5f;

        public int attackDamage = 10;
        private Vector3 toOther;

        void OnEnable()
        {
            SetInitialReferences();
            enemyMaster.EventEnemySetNavTarget += SetAttackTarget;
        }

        void OnDisable()
        {
            enemyMaster.EventEnemySetNavTarget -= SetAttackTarget;
        }

        // Update is called once per frame
        void Update()
        {
            TryToAttack();
        }

        void SetInitialReferences()
        {
            enemyMaster = GetComponent<EnemyMaster>();
            myTransform = transform;
        }

        void SetAttackTarget(Transform targetTransform)
        {
            attackTarget = targetTransform;
        }

        void TryToAttack()
        {
            if (attackTarget != null)
            {
                if (Time.time > nextAttack)
                {
                    nextAttack = Time.time + attackRate;
                    if (Vector3.Distance(myTransform.position, attackTarget.position)<= attackRange)
                    {
                        Vector3 lookAtVector = new Vector3(attackTarget.position.x, myTransform.position.y, attackTarget.position.z);
                        myTransform.LookAt(lookAtVector);
                        enemyMaster.CallEventEnemyAttack();
                        enemyMaster.isOnRoute = false;
                    }
                }
            }
        }

        public void OnEnemyAttack() //Called by attack animation
        {
             if (attackTarget != null)
            {
                if(Vector3.Distance(myTransform.position, attackTarget.position) <= attackRange &&
                    attackTarget.GetComponent<PlayerMaster>() != null)
                {
                    Vector3 toOther = attackTarget.position = myTransform.position;
                    //Debug.Log(Vector3.Dot(toOther, myTransform.forward).ToString());
                }

                if (Vector3.Dot(toOther, myTransform.forward) > 0.5f)
                {
                    attackTarget.GetComponent<PlayerMaster>().CallEventPlayerHealthDeduction(attackDamage);
                }
            }
        } 
            

        void DisableThis()
        {
            this.enabled = false;
        }
    }
}

