using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Status : MonoBehaviour
{
    //Count time for decrease & increase values
    float timer = 0;

    // it is going to be up & down, up & down
    public int intelligence { get; set; } = 100;

    // the value is going to be decrease
    public int health { get; set; } = 100;


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
