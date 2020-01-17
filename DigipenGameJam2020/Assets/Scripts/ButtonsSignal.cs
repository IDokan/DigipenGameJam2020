using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonsSignal : MonoBehaviour
{
    public void signalButton(int count)
    {
        Time time = GameObject.FindGameObjectWithTag("Days").GetComponent<Time>();
        time.dayCount(count);
    }
}
