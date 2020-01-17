using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Moderator_Cmpt : MonoBehaviour
{
    [SerializeField]
    public string givenString;
    public string answer;

    public KeyValuePair<string, string> question;

    // Start is called before the first frame update
    void Start()
    {
        question.Key = "H_ll_ World";
        question.Value = "eo";

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Answer processing
    void Correct()
    {
        // Get First character of answer
        char c = question.Value.IndexOf(0);

        // Remove first character from answer string

        // find first location of '_'

        // Replcate it with given c
    }

    // something Callback
}
