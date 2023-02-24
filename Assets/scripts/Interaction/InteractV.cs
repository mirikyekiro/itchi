using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class InteractV : MonoBehaviour
{
    private bool _insideCollider;
    public GameObject text;

    void Start()
    {
        
    }

    void Update()
    {
        if (_insideCollider) text.SetActive(true);
        else if (_insideCollider == false) text.SetActive(true);
    }

    void OnTriggerStay2D(Collider2D other)
    {
        //Debug.Log("Eable");
        _insideCollider = true;


    }
    void OnTriggerExit2D(Collider2D other)
    {
        _insideCollider = false;
    }

}
