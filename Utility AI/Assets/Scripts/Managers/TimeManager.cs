using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    public Vector2 CurrentTime;
    [Range(0.1f, 60)] public float TimeScale = 1;

    public Days Day;
    public enum Days
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Time.timeScale = TimeScale;
        AddMinute();
    }

    void AddMinute()
    {
        CurrentTime.y += Time.deltaTime;

        if(CurrentTime.y > 60)
        {
            AddHour();
            CurrentTime.y = 0;
        }
    }

    void AddHour()
    {
        CurrentTime.x++;

        if(CurrentTime.x == 24)
        {
            AddDay();
            CurrentTime.x = 0;
        }
    }

    void AddDay()
    {
        if ((int)Day == 6)
        {
            Day = 0;
        }
        else
        {
            Day++;
        }
    }
}
