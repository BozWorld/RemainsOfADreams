using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBahevior : MonoBehaviour
{
    public float forceApplied = 50;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        /*
        Debug.Log("ca marche ?");
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce (0, 0);

            var magnitude = 25;

            var force = transform.position - collision.transform.position;

            force.Normalize();
            GetComponent<Rigidbody2D>().AddForce(-force * magnitude);
            Debug.Log("ca marche, vraiment ?");
        }

        if(collision.gameObject.tag == "Stop")
        {
          
        }*/

        Debug.Log("Collision!");
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<Rigidbody>().AddForce(0, forceApplied, 0);
        }

        if (collision.gameObject.tag == "Halte")
        {
            collision.gameObject.GetComponent<Rigidbody>().AddForce(0, 0, 0);
        }
    }
}
