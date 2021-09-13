using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBahevior : MonoBehaviour
{
    public float forceApplied = 50;
    public GameObject Zone;
    public GameObject Escalier;
    public GameObject Block;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            forceApplied = 50;
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.right * forceApplied);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == Zone)
        {
            Escalier.SetActive(true);
            Block.SetActive(false);
        }
    }
}
