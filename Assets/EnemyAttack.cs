using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{


    //[SerializeField] private float attackCooldown;
    //[SerializeField] private float damage;
    //[SerializeField] private CapsuleCollider2D capsuleCollider;
    //[SerializeField] private LayerMask playerLayer;
    //private float cooldownTimer = Mathf.Infinity;



    //// Update is called once per frame
    //private void Update()
    //{
    //    cooldownTimer = Time.deltaTime;

    //    if(PlayerInSight())
    //    {
    //        if (cooldownTimer >= attackCooldown)
    //        {
    //            //Attack

    //        }
    //    }
     
    //}

    //private bool PlayerInSight()
    //{
    //    RaycastHit2D hit = Physics2D.BoxCast(capsuleCollider.bounds.center, capsuleCollider.bounds.size, 0, Vector2.left, 0,playerLayer);
    //    return hit.collider != null;
    //}

    //private void OnDrawGizmos()
    //{
    //    Gizmos.color = Color.red;
    //    Gizmos.DrawWireCube(capsuleCollider.bounds.center, capsuleCollider.size);
    //}
   
}
