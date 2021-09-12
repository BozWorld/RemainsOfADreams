using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class temporarypuzzlescript : MonoBehaviour
{
    public float Dalle = 0;

    public GameObject reactivateGreen;
    public GameObject reactivateYellow;
    public GameObject reactivateRed;

    public Animator him;

    public void Start()
    {
        GameObject[] reactivateGreen = GameObject.FindGameObjectsWithTag("GreenDalle");
        GameObject[] reactivateYellow = GameObject.FindGameObjectsWithTag("YellowDalle");
        GameObject[] reactivateRed = GameObject.FindGameObjectsWithTag("RedDalle");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.gameObject.tag == "Reactivate")
        {
            reactivateGreen.SetActive(true);
            reactivateYellow.SetActive(true);
            reactivateRed.SetActive(true);
            Dalle = 0;
            him.SetBool("UP", true);
            him.SetBool("Down", true);
            Debug.Log("Marche connard !");
        }
    }
}

