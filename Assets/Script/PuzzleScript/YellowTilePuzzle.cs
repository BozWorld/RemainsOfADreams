using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowTilePuzzle : MonoBehaviour
{
    public GameObject me;
    public GameObject Block;
    public Animator him;

    public PlayerController player;

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (player.Dalle == 2)
            {
                Block.SetActive(true);
                Debug.Log("please");
                him.SetBool("UP", true);
                me.SetActive(false);
            }
            if (player.Dalle == 3)
            {
                Block.SetActive(true);
                him.SetBool("UP", true);
                me.SetActive(false);
            }
            if (player.Dalle == 1)
            {
                player.Dalle = 2;
                me.SetActive(false);
            }

        }
    }
}
