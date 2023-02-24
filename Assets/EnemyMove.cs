using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    private Animator animator;
    private Transform target;
    public Transform homePos;
    [SerializeField] private float speed;
    [SerializeField] private float maxRange;
    [SerializeField] private float minRange;

    // Start is called before the first frame update
    void Start()
    {
        animator= GetComponent<Animator>();
        target = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(target.transform.position, transform.position) <= maxRange && Vector2.Distance(target.position, transform.position) >= minRange)
        {
            FollowPlayer();
        }
        else if(Vector2.Distance(target.transform.position, transform.position) >=maxRange)
        {
            GoHome();
        }
    }
    public void FollowPlayer()
    {
        animator.SetBool("isMoving", true);
        animator.SetFloat("Horizontal", (target.position.x - transform.position.x));
        animator.SetFloat("Vertical", (target.position.y - transform.position.y));
        transform.position = Vector2.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);
    }

    public void GoHome()
    {
        animator.SetFloat("Horizontal", (homePos.position.x - transform.position.x));
        animator.SetFloat("Vertical", (homePos.position.y - transform.position.y));
        transform.position = Vector2.MoveTowards(transform.position, homePos.position, speed * Time.deltaTime); 

        if(Vector2.Distance(transform.position, homePos.transform.position) == 0)
        {
            animator.SetBool("isMoving", false);
        }
    }

}
