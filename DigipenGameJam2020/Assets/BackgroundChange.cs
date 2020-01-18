using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundChange : MonoBehaviour
{
    public Sprite toilet;
    public Sprite classroom;
    public Sprite cafeteria;
    public Sprite studio;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = toilet;
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = classroom;
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = cafeteria;
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = studio;
        }
    }
}

