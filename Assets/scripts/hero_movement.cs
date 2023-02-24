using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class hero_movement : MonoBehaviour
{
    [SerializeField] private float speed;
    public Animator animator;
    private Vector2 direction;
    private Rigidbody2D rb;

    public float health;
    public int numOfHearths;
    public Image[] hearths;
    public Sprite empty_health;
    public Sprite full_health;

    public GameObject deathScreen;

    private bool flashActive;
    [SerializeField] private float flashLength = 0f;
    private float flashCounter = 0f;
    private SpriteRenderer playerSprite;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        playerSprite= GetComponent<SpriteRenderer>();
        
    }

    // Update is called once per frame
   
    void Update()
    {
        direction.x = Input.GetAxisRaw("Horizontal");
        direction.y = Input.GetAxisRaw("Vertical");
        
        animator.SetFloat("Horizontal", direction.x);
        animator.SetFloat("Vertical", direction.y);
        animator.SetFloat("Speed", direction.sqrMagnitude);

        if(flashActive)
        {
            if(flashCounter > flashLength * .99f)
            {
                playerSprite.color = new Color(playerSprite.color.r, playerSprite.color.g, playerSprite.color.b, 0f);
            }
            else if(flashCounter > flashLength * .82f)
            {
                playerSprite.color = new Color(playerSprite.color.r, playerSprite.color.g, playerSprite.color.b, 1f);
            }
            else if(flashCounter>flashLength * .66f)
            {
                playerSprite.color = new Color(playerSprite.color.r, playerSprite.color.g, playerSprite.color.b, 0f);
            }
            else if(flashCounter>flashLength * .49f)
            {
                playerSprite.color = new Color(playerSprite.color.r, playerSprite.color.g, playerSprite.color.b, 1f);
            }
            else if (flashCounter > flashLength * .33f)
            {
                playerSprite.color = new Color(playerSprite.color.r, playerSprite.color.g, playerSprite.color.b, 0f);
            }
            else if (flashCounter > flashLength * .16f)
            {
                playerSprite.color = new Color(playerSprite.color.r, playerSprite.color.g, playerSprite.color.b, 1f);
            }
            else if (flashCounter > 0f)
            {
                playerSprite.color = new Color(playerSprite.color.r, playerSprite.color.g, playerSprite.color.b, 0f);
            }
            else
            {
                playerSprite.color = new Color(playerSprite.color.r, playerSprite.color.g, playerSprite.color.b, 1f);
                flashActive= false;
            }
            flashCounter -= Time.deltaTime;
        }

    }

    void FixedUpdate()
    {
        if (health > numOfHearths)
        {
            health = numOfHearths;
        }
        for (int i = 0; i < hearths.Length; i++)
        {
            if (i < Mathf.RoundToInt(health))
            {
                hearths[i].sprite = full_health;
            }
            else
            {
                hearths[i].sprite = empty_health;
            }
            if(i<numOfHearths)
            {
                hearths[i].enabled = true;
            }
            else
            {
                hearths[i].enabled = false;
            }
            if (health<1)
            {
                deathScreen.SetActive(true);
                Destroy(gameObject);
            }
        }

        rb.MovePosition(rb.position + direction * speed * Time.fixedDeltaTime);
    }

    //
    public void TakeDamage(int damage)
    {
        //stopTime = startStopTime;
        health -= damage;
        flashActive = true;
        flashCounter = flashLength;
    }
    //
}
