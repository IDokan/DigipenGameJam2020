using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonsSignal : MonoBehaviour
{
    public void signalButton(int counting)
    {
        Life_days daysCount = GameObject.FindGameObjectWithTag("Days").GetComponent<Life_days>();
        daysCount.dayCount(counting);
    }

    public void signalEat(int counting)
    {
        Status stat = GameObject.FindGameObjectWithTag("Player").GetComponent<Status>();
        stat.EatSignal(counting);
    }

    public void signalUrin(int counting)
    {
        Status stat = GameObject.FindGameObjectWithTag("Player").GetComponent<Status>();
        stat.UrinSignal(counting);
    }

    public void signalRestOrPlay(int counting)
    {
        Status stat = GameObject.FindGameObjectWithTag("Player").GetComponent<Status>();
        stat.RestOrPlaySignal(counting);
    }

    public void signalSleep(int counting)
    {
        Status stat = GameObject.FindGameObjectWithTag("Player").GetComponent<Status>();
        stat.SleepSignal(counting);
    }

    public void signalStudy(int counting)
    {
        Status stat = GameObject.FindGameObjectWithTag("Player").GetComponent<Status>();
        stat.StudySignal(counting);
    }

}
