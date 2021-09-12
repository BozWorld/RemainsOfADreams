using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class temporarypuzzlescript : MonoBehaviour
{
    public float Dalle = 0;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "GreenDalle")
        {
            if (Dalle == 1)
            {
                Debug.Log("death");
            }
            if (Dalle == 2)
            {
                Debug.Log("death");
            }
            if (Dalle == 0)
            {
                Dalle = 1;
            }
            if (Dalle == 3)
            {
                Dalle = 1;
            }
        }

        if (other.gameObject.tag == "YellowDalle")
        {
            if (Dalle == 0)
            {
                Debug.Log("death");
            }
            if (Dalle == 2)
            {
                Debug.Log("death");
            }
            if (Dalle == 3)
            {
                Debug.Log("death");
            }
            if (Dalle == 1)
            {
                Dalle = 2;
            }

        }

        if (other.gameObject.tag == "RedDalle")
        {
            if (Dalle == 0)
            {
                Debug.Log("death");
            }
            if (Dalle == 1)
            {
                Debug.Log("death");
            }
            if (Dalle == 3)
            {
                Debug.Log("death");
            }
            if (Dalle == 2)
            {
                Dalle = 3;
            }
        }
    }
}

