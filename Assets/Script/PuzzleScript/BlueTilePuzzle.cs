using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueTilePuzzle : MonoBehaviour
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
            if (player.Dalle == 1)
            {
                Block.SetActive(true);
                him.SetBool("UP", true);
                me.SetActive(false);
            }
            if (player.Dalle == 2)
            {
                Block.SetActive(true);
                him.SetBool("UP", true);
                me.SetActive(false);
            }
            if (player.Dalle == 0)
            {
                player.Dalle = 1f;
                him.SetBool("Down", false);
                him.SetBool("UP", false);
                me.SetActive(false);
            }
            if (player.Dalle == 3)
            {
                player.Dalle = 1f;
                me.SetActive(false);
            }
        }
    }
}
