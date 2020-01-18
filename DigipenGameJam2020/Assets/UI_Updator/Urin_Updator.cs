using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;
using UnityEngine.Events;


[System.Serializable]
public class Urin_Updator : MonoBehaviour
{
    [SerializeField]
    private GameObject player = null;
    [SerializeField]
    public Slider slider = null;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Text representText = GetComponent<Text>();
        Status status = player.GetComponent<Status>();
        representText.text = (status.urin).ToString();
        slider.value = status.urin;
    }
}
