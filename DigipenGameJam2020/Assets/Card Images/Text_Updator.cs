using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Text_Updator : MonoBehaviour
{
    public GameObject moderator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Text text = GetComponent<Text>();
        text.text = moderator.GetComponent<Moderator_Cmpt>().givenString;
    }
}
