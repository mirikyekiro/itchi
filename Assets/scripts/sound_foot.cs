using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound_foot : MonoBehaviour
{
    public AudioSource _footstepSound;
    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {_footstepSound.enabled = true;}
        else
        {_footstepSound.enabled = false;}
    }
}
