using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Status : MonoBehaviour
{
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
        
    }

    public void EatSignal(int count)
    {
        hunger -= count;
        fatigue -= 2;
        urin += count - 2;
    }

    public void UrinSignal(int count)
    {
        urin -= count;

    }

    public void RestOrPlaySignal(int count)
    {
        fatigue -= count;
        intelligence -= 2;
    }

    public void SleepSignal(int count)
    {
        fatigue -= count;

    }

    public void StudySignal(int count)
    {
        intelligence += count;
        fatigue += 3;
    }
}
