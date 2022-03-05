using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    public float startTime = 100;
    float timeLeft;
    bool timerRunning;
    public Text timeText;
    StartGame sg;

    // Start is called before the first frame update
    void Start()
    {
        timeLeft = startTime;
        timerRunning = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (timerRunning)
        {
            if (timeLeft > 0)
            {
                timeLeft -= Time.deltaTime;
                displayTime(timeLeft);
            }
            else
            {
                timeLeft = 0;
                timerRunning = false;
                sg = FindObjectOfType<StartGame>();
                sg.GameOverScreen();
            }


        }
    }

    public void displayTime(float displayTime)
    {
        displayTime += 1;
        float minutes = Mathf.FloorToInt(displayTime / 60);
        float seconds = Mathf.FloorToInt(displayTime % 60);
        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}