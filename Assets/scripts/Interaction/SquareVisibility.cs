using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareVisibility : MonoBehaviour
{
    SpriteRenderer rend;
    [SerializeField] bool _insideCollider;

    void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        rend.enabled = false;
    }

    void Update()
    {
        if (_insideCollider) rend.enabled = true;
        else if (_insideCollider == false) rend.enabled = false;
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
