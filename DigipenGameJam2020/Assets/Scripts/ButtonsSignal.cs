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
}
