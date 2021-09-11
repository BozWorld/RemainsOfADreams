using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levier2Script : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite newSprite;
    public int ActivateNumber;
    public GameObject Passage;
    public GameObject bloc;

    private void OnCollisionStay2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            spriteRenderer.sprite = newSprite;
            ActivateNumber = 2;
        }
    }
    private void OnCollisionexit2D(Collision2D col)
    {
        if (ActivateNumber == 2)
        {
            Passage.SetActive(true);
            bloc.SetActive(false);
        }
    }
}
