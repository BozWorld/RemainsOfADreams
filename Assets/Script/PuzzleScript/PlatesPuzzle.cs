using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatesPuzzle : MonoBehaviour
{
    public GameObject Plate01;
    public GameObject Plate02;
    public GameObject Plate03;
    public GameObject Plate04;
    public float ordre = 0f;
    public GameObject Passage;
    public GameObject Block;
    public GameObject Recover;

    // Start is called before the first frame update
    void Start()
    {
        GameEvent.current.onPlatesPuzzle += OnPlatesPuzzle;
    }

    private void OnPlatesPuzzle()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(ordre == 4)
        {
            Passage.SetActive(true);
            Block.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject == Recover)
        {
            Plate01.SetActive(true);
            Plate02.SetActive(true);
            Plate03.SetActive(true);
            Plate04.SetActive(true);
            ordre = 0f;
        }

        if (collision.gameObject == Plate01 && ordre == 0)
        {
            ordre = 1f;
        }

        if (collision.gameObject == Plate01)
        {
            Plate01.SetActive(false);
        }

        if (collision.gameObject == Plate02 && ordre == 1)
        {
            ordre = 2f;
        }

        if (collision.gameObject == Plate02)
        {
            Plate02.SetActive(false);
        }

        if (collision.gameObject == Plate03 && ordre == 2)
        {
            ordre = 3f;
        }

        if (collision.gameObject == Plate03)
        {
            Plate03.SetActive(false);
        }

        if (collision.gameObject == Plate04 && ordre == 3)
        {
            ordre = 4f;
        }

        if (collision.gameObject == Plate04)
        {
            Plate04.SetActive(false);
        }
    }
}
