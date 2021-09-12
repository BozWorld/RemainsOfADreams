using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBahevior : MonoBehaviour
{
    public float forceApplied = 50;

    private void OnCollisionEnter2D(Collision2D collision)
    {

        Debug.Log("Collision!");
        if (collision.gameObject.tag == "Player")
        {
            forceApplied = 50;
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.right * forceApplied);
        }
        
        if (collision.gameObject.tag == "Halte")
        {
            forceApplied = 0;
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.right * forceApplied);
        }
    }
}
