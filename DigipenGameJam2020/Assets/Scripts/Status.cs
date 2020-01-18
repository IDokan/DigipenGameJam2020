using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Status : MonoBehaviour
{
    //Count time for decrease & increase values
    float timer = 0;

    //place sprites
    public Sprite classroom;
    public Sprite studio;
    public Sprite toilet;
    public Sprite cafe;

    //character sprites
    public Sprite sleeping;
    public Sprite presentation;
    public Sprite standing;


    // it is going to be up & down, up & down
    public int intelligence { get; set; } = 0;

    // the values are going to be increse
    public int fatigue { get; set; } = 0;
    public int urin { get; set; } = 0;
    public int hunger { get; set; } = 0;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 5) //use && to check if player is not eating or sleeping
        {
            timer = 0;
            if(hunger < 100)
            {
                ++hunger;
            }
            if(fatigue < 100)
            {
                ++fatigue;
            }
            if(urin < 100)
            {
                ++urin;
            }
        }

        if (urin > 100)
            urin = 100;
        if (hunger > 100)
            hunger = 100;
        if (fatigue > 100)
            fatigue = 100;
        


        if (GameObject.Find("Background").GetComponent<SpriteRenderer>().sprite == classroom)
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

    public void EatSignal(int count)
    {
        hunger -= count;
        fatigue -= 2;
        urin += count - 2;
        if (urin > 100)
            urin = 100;
        if (hunger < 0)
            hunger = 0;
        if (fatigue < 0)
            fatigue = 0;
            
    }

    public void UrinSignal(int count)
    {
        urin -= count;
        if (urin < 0)
            urin = 0;

    }

    public void RestOrPlaySignal(int count)
    {
        fatigue -= count;
        intelligence -= 2;

        if (fatigue < 0)
            fatigue = 0;
        if (intelligence < 0)
            intelligence = 0;
    }

    public void SleepSignal(int count)
    {
        fatigue -= count;
        if (fatigue < 0)
            fatigue = 0;

    }

    public void StudySignal(int count)
    {
        intelligence += count;
        fatigue += 3;

        if (intelligence > 100)
            intelligence = 100;

        if (fatigue > 100)
            fatigue = 100;
    }
}
