using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.UI;

public class NameChanging : MonoBehaviour
{
    [SerializeField] bool _insideCollider;
    public TMP_Text nameText;
    int count = 0;

    public void Start()
    {
        
    }

    public void NameChange(Dialogue dialogue)
    {
        if (count == 2)
        {
            dialogue.name = "Èýéèýõñèò";
            nameText.text = dialogue.name;
        }
        
    }

    public void Counter()
    {
        count++;
    }

    void OnTriggerStay2D(Collider2D other)
    {
        _insideCollider = true;
    }
    void OnTriggerExit2D(Collider2D other)
    {
        _insideCollider = false;
        count = 0;
    }

}
