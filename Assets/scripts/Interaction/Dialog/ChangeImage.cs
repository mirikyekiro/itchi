using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeImage : MonoBehaviour
{
    [SerializeField] int count = 0; 
    //4,8,10
    [Header("Sprite")]
    [SerializeField] private SpriteRenderer Sprite;

    [Header("Image")]
    [SerializeField] private Image img;

    [Header("Sprites")]
    [SerializeField] private Sprite sprite1;
    [SerializeField] private Sprite sprite2;

    public void ChangeSprite()
    {
        count++;
        
        Sprite.sprite = sprite1;

        img.sprite = sprite2;
        if (count == 4 || count == 8 || count == 10)
        {
            img.sprite = sprite1;


        }
        if(count > 10)
        {
            count = 0;
        }
    }
}
