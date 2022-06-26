using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{

    public static float timeRemaining = 10;
    public bool  timerIsRunning = false;
    public Text  timeText;
    public float tmpTime = 200;

    private void Start()
    {
         if(SceneManager.GetActiveScene().name!="Main" && SceneManager.GetActiveScene().name!="LastSecne")
         {
              timerIsRunning = true;
              timeRemaining = 120;
         }
    }

    void Update()
    {
        if (timeRemaining > 0)
        {
             timeRemaining = timeRemaining - Time.deltaTime ;
             System.Math.Round(timeRemaining,2);
             DisplayTime(timeRemaining);
       }
        else
        {
                timeRemaining = 0;
                timerIsRunning = false;
       }
     }

    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;
        float minutes = Mathf.FloorToInt(timeToDisplay / 60); 
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        if(timeText.text=="00:00")
        {
         // SceneManager.LoadScene("LostSecne");
        }      

    }
}
