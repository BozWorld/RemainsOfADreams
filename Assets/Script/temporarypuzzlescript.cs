using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class temporarypuzzlescript : MonoBehaviour
{
    public float Dalle = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "GreenDalle")
        {
            if (Dalle == 0)
            {
                Dalle = 1;
            }
            if (Dalle == 1)
            {
                Debug.Log("death");
            }
            if (Dalle == 2)
            {
                Debug.Log("death");
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
            if (Dalle == 1)
            {
                Dalle = 2;
            }
            if (Dalle == 2)
            {
                Debug.Log("death");
            }
            if (Dalle == 3)
            {
                Debug.Log("death");
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
            if (Dalle == 2)
            {
                Dalle = 3;
            }
            if (Dalle == 3)
            {
                Debug.Log("death");
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            /*collision.gameObject.GetComponent<Rigidbody2D>().AddForce (0, 0);*/

            var magnitude = 2500;

            var force = transform.position - collision.transform.position;

            force.Normalize();
            GetComponent<Rigidbody2D>().AddForce(-force * magnitude);
        }
    }
}

