using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundChange : MonoBehaviour
{
    public Sprite toilet;
    public Sprite classroom;
    public Sprite cafeteria;
    public Sprite studio;


    // Update is called once per frame
    public void toiletView()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = toilet;

    }

    public void classroomView()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = classroom;
    }

    public void cafeteriaView()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = cafeteria;
    }

    public void studioView()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = studio;
    }
}

