using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levier1Script : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite newSprite;
    public int ActivateNumber;

    private void OnCollisionStay2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            spriteRenderer.sprite = newSprite;
            ActivateNumber = 1;
        }
    }

}
