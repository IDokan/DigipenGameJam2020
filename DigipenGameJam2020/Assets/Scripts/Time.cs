using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Time : MonoBehaviour
{
    public int behavior;
    public int day;
    public int week;
    public int semester;
    public int year;

    int whole_Day;
    int whole_Week;
    int whole_Behavior;
    int year_Semester;
    int whole_Year;

    // Start is called before the first frame update
    void Start()
    {
        behavior = 0;
        week = 0;
        semester = 0;

        whole_Behavior = 5;
        whole_Day = 7;
        whole_Week = 12;
        year_Semester = 2;
        whole_Year = 4;
    }

    public void dayCount(int count)
    {
        behavior += count;

        if(behavior == whole_Behavior)
        {
            day++;
            behavior = 0;
        }

        if(day == whole_Day)
        {
            week++;
            day = 0;
        }


        if(week == whole_Week)
        {
            semester++;
            week = 0;
        }

        if(semester == year_Semester)
        {
            year++;
            semester = 0;
        }

        if(year == whole_Year)
        {
            //gameEnding();
        }

    }
}
