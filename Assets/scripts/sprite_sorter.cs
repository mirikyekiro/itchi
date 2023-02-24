using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sprite_sorter : MonoBehaviour
{
    [SerializeField] private int sortingOrderBase = 5000;
    [SerializeField] public bool isStatic = false;
    [SerializeField] public float offset =0;
    private float timer;
    private float timerMax = .1f;
    private Renderer renderer;
    private void Awake()
    {
        renderer = GetComponent<Renderer>();
    }
    private void LateUpdate()
    {
        timer -= Time.deltaTime;
        if (timer <= 0f)
        {
            renderer.sortingOrder = (int)(sortingOrderBase - transform.position.y - offset);
            if (isStatic)
            {
                Destroy(this);
            }
        }
    }
}
