using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;
using UnityEngine.Events;

[System.Serializable]
public class PropertyUIUpdator : MonoBehaviour
{
    [SerializeField]
    private GameObject player = null;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Text stats = GetComponent<Text>();
        Status status = player.GetComponent<Status>();
        stats.text = (status.fatigue).ToString();
    }
}