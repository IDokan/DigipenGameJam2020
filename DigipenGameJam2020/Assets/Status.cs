using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Status : MonoBehaviour
{
    public int fatigue;
    public int health;
    public int intelligence;
    public int urin;
    public int hunger;
    public int stress;

    // Start is called before the first frame update
    void Start()
    {
        // variables are going to be decreased
        // Thus, initial value is 100
        health = 100;
        intelligence = 100;

        // variables are going to be increased
        // Thus, initial value is 0
        fatigue = 0;
        urin = 0;
        hunger = 0;
        stress = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
