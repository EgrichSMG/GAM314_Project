using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float targetTime;
    public bool timerOn = true;

    public Text TimerTxt;

    void Start()
    {
        
    }

    void Update()
    {
        if (targetTime > 0)
        {
            targetTime -= Time.deltaTime;
            updateTime(targetTime);
        }
        else
        {
            timerEnded();
        }
        
    }

    void updateTime(float currentTime)
    {
        currentTime += 1;

        float minutes = currentTime / 60;
        float seconds = currentTime % 60;

        TimerTxt.text = string.Format("{0:00} : {1:00}", minutes, seconds);
    }

    void timerEnded()
    {
        Debug.Log("Time's up!");
        targetTime = 0;
        timerOn = false;
    }

}
