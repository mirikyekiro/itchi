using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class light_flicker : MonoBehaviour
{
    [SerializeField] Light _light;
    [SerializeField] float _intensity;
    [SerializeField] float _frequency;
    // Start is called before the first frame update
    
    // Update is called once per frame
    void Update()
    {
        _light.intensity = Mathf.PerlinNoise(Time.time * _frequency , 0f) * _intensity;
    }
}
