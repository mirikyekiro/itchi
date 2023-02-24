using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Hero_Attack : MonoBehaviour
{
    private float timeBtwAttack;
    public float startTimeBtwAttack;

    

    public Transform attackPos;
    public LayerMask Enemy;
    public float attackRange;
    public int damage;
    public Animator animator;

    private void Update()
    {
        if(timeBtwAttack<=0)
        {
            if(Input.GetMouseButton(0))
            {
                animator.SetTrigger("attack");
                Collider2D[] enemies = Physics2D.OverlapCircleAll(attackPos.position, attackRange, Enemy);
                for (int i = 0; i < enemies.Length; i++)
                {
                    enemies[i].GetComponent<Enemy>().TakeDamage(damage);
                }
            }
            timeBtwAttack = startTimeBtwAttack;
        }
        else
        {
            timeBtwAttack -= Time.deltaTime;
        }
    }

    //public void OnAttack()
    //{
        
   // }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(attackPos.position, attackRange);
    }
}
