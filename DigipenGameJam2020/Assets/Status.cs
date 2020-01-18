using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Status : MonoBehaviour
{
    //Count time for decrease & increase values
    float timer = 0;

    //place sprites
    public Sprite classroom;
    public Sprite studio;
    public Sprite toilet;
    public Sprite cafe;

    // it is going to be up & down, up & down
    public int intelligence { get; set; } = 100;

    // the value is going to be decrease
    public int health { get; set; } = 100;

    //character sprites
    public Sprite sleeping;
    public Sprite presentation;
    public Sprite standing;

    // the values are going to be increse
    public int fatigue { get; set; } = 0;
    public int urin { get; set; } = 0;
    public int hunger { get; set; } = 0;
    public int stress { get; set; } = 0;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer > 5) //use && to check if player is not eating or sleeping
        {
            timer = 0;
            ++fatigue;
            --health;
            ++hunger;
            ++urin;
        }

        //example code for resetting values
        if (health == 0)
            resetStatus('b');
        if(GameObject.Find("Background").GetComponent<SpriteRenderer>().sprite == classroom)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = presentation;
            gameObject.GetComponent<Transform>().position = new Vector3(0.01f, -3.2f, -0.01f);
        }
        else if (GameObject.Find("Background").GetComponent<SpriteRenderer>().sprite == studio)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = sleeping;
            gameObject.GetComponent<Transform>().position = new Vector3(1.8f, 0.51f, -0.01f);
        }
        else if (GameObject.Find("Background").GetComponent<SpriteRenderer>().sprite == toilet)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = standing;
            gameObject.GetComponent<Transform>().position = new Vector3(0.01f, -3.2f, -0.01f);
        }
        else if (GameObject.Find("Background").GetComponent<SpriteRenderer>().sprite == cafe)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = standing;
            gameObject.GetComponent<Transform>().position = new Vector3(1.11f, -0.57f, -0.01f);
        }

    }

    //helper function
    void resetStatus(char signal)
    {
        if (signal == 'a')
            fatigue = 0;
        if (signal == 'b')
            health = 100;
        if (signal == 'c')
            hunger = 0;
        if (signal == 'd')
            urin = 0;
    }
}
