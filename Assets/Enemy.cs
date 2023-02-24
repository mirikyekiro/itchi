using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Enemy : MonoBehaviour
{
    private float timeBtwAttack;
    public float startTimeBtwAttack;

    private bool flashActive;
    [SerializeField] private float flashLength = 0f;
    private float flashCounter = 0f;
    private SpriteRenderer enemySprite;

    //
    public float attackRange;
    public Transform attackPos;
    public LayerMask Player;
    //

    public int health;
    public float speed;
    public int damage;
    private float stopTime;
    public float startStopTime;
    public float normalSpeed;
    private Transform target;
    private Animator animator;
    Rigidbody2D rb;

    private void Start()
    {
        animator = GetComponent<Animator>();
        enemySprite = GetComponent<SpriteRenderer>();
        target = GameObject.FindWithTag("Player").transform;
        rb = animator.GetComponent<Rigidbody2D>();
        normalSpeed = speed;
    }


    private void Update()
    {
        if (flashActive)
        {
            if (flashCounter > flashLength * .99f)
            {
                enemySprite.color = new Color(enemySprite.color.r, enemySprite.color.g, enemySprite.color.b, 0f);
            }
            else if (flashCounter > flashLength * .82f)
            {
                enemySprite.color = new Color(enemySprite.color.r, enemySprite.color.g, enemySprite.color.b, 1f);
            }
            else if (flashCounter > flashLength * .66f)
            {
                enemySprite.color = new Color(enemySprite.color.r, enemySprite.color.g, enemySprite.color.b, 0f);
            }
            else if (flashCounter > flashLength * .49f)
            {
                enemySprite.color = new Color(enemySprite.color.r, enemySprite.color.g, enemySprite.color.b, 1f);
            }
            else if (flashCounter > flashLength * .33f)
            {
                enemySprite.color = new Color(enemySprite.color.r, enemySprite.color.g, enemySprite.color.b, 0f);
            }
            else if (flashCounter > flashLength * .16f)
            {
                enemySprite.color = new Color(enemySprite.color.r, enemySprite.color.g, enemySprite.color.b, 1f);
            }
            else if (flashCounter > 0f)
            {
                enemySprite.color = new Color(enemySprite.color.r, enemySprite.color.g, enemySprite.color.b, 0f);
            }
            else
            {
                enemySprite.color = new Color(enemySprite.color.r, enemySprite.color.g, enemySprite.color.b, 1f);
                flashActive = false;
            }
            flashCounter -= Time.deltaTime;
        }

        //
        //if(Vector2.Distance(target.transform.position, rb.transform.position) <= attackRange)
        //{
        //    animator.SetTrigger("meleeAttack");
        //}
        if (timeBtwAttack <= 0)
        {
            //animator.SetTrigger("meleeAttack");
            Collider2D[] player = Physics2D.OverlapCircleAll(attackPos.position, attackRange, Player);
            for (int i = 0; i < player.Length; i++)
            {
                player[i].GetComponent<hero_movement>().TakeDamage(damage);
            }

            timeBtwAttack = startTimeBtwAttack;
        }
        //

        else
        {
            timeBtwAttack -= Time.deltaTime;
        }

        if (stopTime <=0)
        {
            speed = normalSpeed;
        }
        else
        {
            speed = 0;
            stopTime -= Time.deltaTime;
        }

        if (health<=0)
        {
            Destroy(gameObject);
        }
       // transform.Translate(Vector2.left * speed * Time.deltaTime);
    }
    public void TakeDamage(int damage)
    {
        stopTime = startStopTime;
        health -= damage;
        flashActive = true;
        flashCounter = flashLength;
    }


    //
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(attackPos.position, attackRange);
    }

    //






    //public void OnTriggerStay2D(Collider2D other)
    //{
    //    if (other.CompareTag("Player"))
    //    {
    //        if (timeBtwAttack <= 0)
    //        {
    //            animator.SetTrigger("meleeAttack");



    //        }
    //        else
    //        {
    //            timeBtwAttack-=Time.deltaTime;
    //        }
    //    }
    //}

    //public void OnEnemyAttack()
    //{
    //    player.health -= damage;
    //    timeBtwAttack = startTimeBtwAttack;
    //}
}
