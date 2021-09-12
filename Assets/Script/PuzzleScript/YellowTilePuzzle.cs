using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowTilePuzzle : temporarypuzzlescript
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
            if (Dalle == 2)
            {
                Block.SetActive(true);
                him.SetBool("UP", true);
                me.SetActive(false);
            }
            if (Dalle == 3)
            {
                Block.SetActive(true);
                him.SetBool("UP", true);
                me.SetActive(false);
            }
            if (Dalle == 1)
            {
                Dalle = 2;
                me.SetActive(false);
            }

        }
    }
}
