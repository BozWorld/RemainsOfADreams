using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class temporarypuzzlescript : MonoBehaviour
{

    public GameObject[] Green;
    public GameObject[] Yellow;
    public GameObject[] Red;

    public Animator him;

    public PlayerController player;
    public GameObject Block;

    public GameObject Boule;
    public GameObject DepartBoule;

    public void Start()
    {
        GameObject[] Green = GameObject.FindGameObjectsWithTag("GreenDalle");
        GameObject[] Yellow = GameObject.FindGameObjectsWithTag("YellowDalle");
        GameObject[] Red = GameObject.FindGameObjectsWithTag("RedDalle");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.gameObject.tag == "Reactivate")
        {
            Boule.transform.position = new Vector3(DepartBoule.transform.position.x, DepartBoule.transform.position.y, 0);
            foreach (GameObject reactivateGreen in Green)
            {
                reactivateGreen.SetActive(true);
            }
            foreach (GameObject reactivateYellow in Yellow)
            {
                reactivateYellow.SetActive(true);
            }
            foreach (GameObject reactivateRed in Red)
            {
                reactivateRed.SetActive(true);
            }
            player.Dalle = 0;
            Block.SetActive(false);
            him.SetBool("Down", true);
        }
    }
}

