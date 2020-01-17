﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Life_days : MonoBehaviour
{
    public int day { get; set; } = 1;
    public int week { get; set; } = 12;
    public int semester { get; set; } = 1;
    public int year { get; set; } = 1;


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

    string studentYear = "Beginner";
    string studentSemester = "Spring";
 

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


        if (behavior == 0)
        {
            day++;
            behavior = 5;
        }

        if (day == whole_Day)
        {
            week++;
            day = 1;
        }


        if (week == whole_Week)
        {
            semester++;
            week = 1;

            if(semester == 2)
            {
                studentSemester = "Fall";
            }

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
