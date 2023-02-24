using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemE : MonoBehaviour
{

    [SerializeField] GameObject item;
    [SerializeField] bool inCollider;

    void Start()
    {
        
    }


    void Update()
    {
        if (inCollider == true && item.tag == "Eable")
        {
            Debug.Log("PressE");
            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("you picked up the stone!");
                Destroy(item.GetComponent<SpriteRenderer>());
                Destroy(item.GetComponent<CircleCollider2D>());
            }
        }
    }
    

    void OnTriggerStay2D(Collider2D other)
    {
        //Debug.Log("Eable");
        inCollider = true;
       
        
    }
    void OnTriggerExit2D(Collider2D other)
    {
        inCollider = false;
    }




}