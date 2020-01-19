using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndingScene : MonoBehaviour
{


    [SerializeField]
    private Text Comment_text = null;
    [SerializeField]
    private Text Comment_text2 = null;

    //place sprites
    public Sprite Blowurin;
    public Sprite Gwarosa;
    public Sprite Starvation;
    public Sprite Fail;
    public Sprite Pass;


    void Start()
    {
        GameObject.Find("Player").GetComponent<Transform>().position = new Vector3(10.0f, -3.2f, -0.01f);

        if (GameObject.Find("Player").GetComponent<Status>().urin >= 100)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Blowurin;
            Comment_text.text = "You were killed by ";
            Comment_text2.text = "a blast of bladder";
        }
        else if (GameObject.Find("Player").GetComponent<Status>().fatigue >= 100)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Gwarosa;
            Comment_text.text = "Your body is made up";
            Comment_text2.text = "of Red Bull";
        }
        else if (GameObject.Find("Player").GetComponent<Status>().hunger >= 100)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Starvation;
            Comment_text.text = "You died eating";
            Comment_text2.text = "only knowledge";
        }
        else if (GameObject.Find("Player").GetComponent<Status>().intelligence >= 100)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Pass;
            Comment_text.text = "Congratulations, ";
            Comment_text2.text = "but don't be conceited";
        }
        else if (GameObject.Find("Player").GetComponent<Status>().intelligence < 100)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Fail;
            Comment_text.text = "Hey bro, ";
            Comment_text2.text = "see you in a year";
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene("TestScene");
    }

    public void QuitScene()
    {
        Application.Quit();
    }

}
