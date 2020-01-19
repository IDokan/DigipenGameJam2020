using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Status : MonoBehaviour
{
    //Count time for decrease & increase values
    float timer = 0;

    Scene currentScene;
    string SceneName;

    //place sprites
    public Sprite classroom;
    public Sprite studio;
    public Sprite toilet;
    public Sprite cafe;

    //character sprites
    public Sprite sleeping;
    public Sprite presentation;
    public Sprite standing;


    // it is going to be up & down, up & down
    public int intelligence { get; set; } = 0;

    // the values are going to be increse
    public int fatigue { get; set; } = 0;
    public int urin { get; set; } = 0;
    public int hunger { get; set; } = 0;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        currentScene = SceneManager.GetActiveScene();
        SceneName = currentScene.name;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 5) //use && to check if player is not eating or sleeping
        {
            timer = 0;
            if (hunger < 100 && SceneName == "TestScene")
            {
                ++hunger;
            }
            if (fatigue < 100 && SceneName == "TestScene")
            {
                ++fatigue;
            }
            if (urin < 100 && SceneName == "TestScene")
            {
                ++urin;
            }
        }

        if (hunger < 0)
            hunger = 0;

        if (fatigue < 0)
            fatigue = 0;

        if (urin < 0)
            urin = 0;

        if (intelligence < 0)
            intelligence = 0;
        else if (intelligence > 100)
            intelligence = 100;


        if (GameObject.Find("Background").GetComponent<SpriteRenderer>().sprite == classroom)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = presentation;
            gameObject.GetComponent<Transform>().position = new Vector3(0.01f, -3.2f, -0.01f);
        }
        else if (GameObject.Find("Background").GetComponent<SpriteRenderer>().sprite == studio)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = sleeping;
            gameObject.GetComponent<Transform>().position = new Vector3(1.8f, 0.51f, -0.01f);
        }
        else if (GameObject.Find("Background").GetComponent<SpriteRenderer>().sprite == toilet)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = standing;
            gameObject.GetComponent<Transform>().position = new Vector3(0.01f, -3.2f, -0.01f);
        }
        else if (GameObject.Find("Background").GetComponent<SpriteRenderer>().sprite == cafe)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = standing;
            gameObject.GetComponent<Transform>().position = new Vector3(1.11f, -0.57f, -0.01f);
        }



    }

    public void EatSignal(int count)
    {
        hunger -= count;
        fatigue -= 2;
        urin += count - 2;

        if (urin >= 100)
        {
            SceneManager.LoadScene("EndingScene");
        }
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

        if (fatigue >= 100)
        {
            SceneManager.LoadScene("EndingScene");
        }

    }
}
