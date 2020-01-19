using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Life_days : MonoBehaviour
{
    public int day { get; set; } = 1;
    public int week { get; set; } = 12;
    public int semester { get; set; } = 2;
    public int year { get; set; } = 2;


    [SerializeField]
    private Text behavior_valueText = null;

    [SerializeField]
    private Text day_valueText = null;

    [SerializeField]
    private Text week_valueText = null;

    [SerializeField]
    private Text semester_valueText = null;

    [SerializeField]
    private Text year_valueText = null;


    int behavior { get; set; } = 5;


    int whole_Day { get; set; } = 8;
    int whole_Week { get; set; } = 13;
    int year_Semester { get; set; } = 3;
    int whole_Year { get; set; } = 5;

    string studentYear = "Sophomore";
    string studentSemester = "Fall";
 

    string[] behaviorTextField;
    string[] dayTextField;
    string[] weekTextField;
    string[] semesterTextField;
    string[] yearTextField;

    void Update()
    {
        behaviorTextField = behavior_valueText.text.Split(':');
        behavior_valueText.text = behaviorTextField[0] + ": " + behavior;

        dayTextField = day_valueText.text.Split(':');
        day_valueText.text = dayTextField[0] + ": " + day;

        weekTextField = week_valueText.text.Split(':');
        week_valueText.text = weekTextField[0] + ": " + week;

        semesterTextField = semester_valueText.text.Split(':');
        semester_valueText.text = semesterTextField[0] + ": " + studentSemester;

        yearTextField = year_valueText.text.Split(':');
        year_valueText.text = yearTextField[0] + ": " + studentYear;

    }

    public void dayCount(int count)
    {
        behavior -= count;
        //GameObject.Find("Player").GetComponent<Status>().fatigue += 2;


        GameObject.Find("Player").GetComponent<Status>().hunger += 3;

        if(GameObject.Find("Player").GetComponent<Status>().hunger >= 100)
        {
            SceneManager.LoadScene("EndingScene");
        }

        if (behavior == 0)
        {
            day++;
            GameObject.Find("Player").GetComponent<Status>().urin += 6;
            if (GameObject.Find("Player").GetComponent<Status>().urin >= 100)
            {
                SceneManager.LoadScene("EndingScene");
            }
            behavior = 5;
        }

        if (day == whole_Day)
        {
            week++;
            day = 1;
        }


        if (week == whole_Week)
        {
            if(GameObject.Find("Player").GetComponent<Status>().intelligence == 100)
            {
                SceneManager.LoadScene("FlipCards");
            }
            else
            {

                SceneManager.LoadScene("EndingScene");
            }

            //semester++;
            //week = 1;

            //if(semester == 2)
            //{
            //    studentSemester = "Fall";
            //}

        }

        if (semester == year_Semester)
        {
            year++;
            semester = 1;
            studentSemester = "Spring";

            if (year == 2)
            {
                studentYear = "Sophomore";
            }
            else if (year == 3)
            {
                studentYear = "Junior";
            }
            else if (year == 4)
            {
                studentYear = "Senior";
            }
            else if (year == whole_Year)
            {
                //gameEnding();
            }
        }
    }
}
