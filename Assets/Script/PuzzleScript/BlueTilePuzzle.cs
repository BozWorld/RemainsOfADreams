using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueTilePuzzle : temporarypuzzlescript
{
    public GameObject me;
    public GameObject Block;

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (Dalle == 1)
            {
                Block.SetActive(true);
                him.SetBool("UP", true);
                me.SetActive(false);
            }
            if (Dalle == 2)
            {
                Block.SetActive(true);
                him.SetBool("UP", true);
                me.SetActive(false);
            }
            if (Dalle == 0)
            {
                Dalle = 1f;
                him.SetBool("Down", false);
                me.SetActive(false);
            }
            if (Dalle == 3)
            {
                Dalle = 1f;
                me.SetActive(false);
            }
        }
    }
}
