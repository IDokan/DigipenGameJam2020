using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Status : MonoBehaviour
{
    // it is going to be up & down, up & down
    public int intelligence { get; set; } = 100;

    // the value is going to be decrease
    public int health { get; set; } = 100;


    // the values are going to be increse
    public int fatigue { get; set; } = 100;
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
        
    }
}
