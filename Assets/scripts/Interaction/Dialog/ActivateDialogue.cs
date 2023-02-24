using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class ActivateDialogue : MonoBehaviour
{
    public GameObject god;
    [SerializeField] bool _insideCollider;
    public Dialogue dialogue;

    public void TriggerDialogue()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }
    public void Update()
    {
        if (_insideCollider && god.tag == "Talkable")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                TriggerDialogue();
            }
        }
        
    }
    void OnTriggerStay2D(Collider2D other)
    {
        _insideCollider = true;


    }
    void OnTriggerExit2D(Collider2D other)
    {
        _insideCollider = false;
    }

}
