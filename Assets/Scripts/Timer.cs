using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
  public Text timerText;
    //private float startTime;
   private bool finnish = false;
    public int TotalTime = 30;

    // Start is called before the first frame update
    void Start()
    {
        //startTime = Time.time;
        StartCoroutine(CountDown());
    }

    // Update is called once per frame
    /*void Update()
      {
          if (finnish)

              return;

          float t = Time.time - startTime;
         string minutes = ((int)t / 60).ToString();
         string seconds = (t % 60).ToString("f2");
          int n = atoi(seconds);
          //string T = 30;
          //string seconds = (T - (int)t % 60).ToString("f2");
          timerText.text = 30 - seconds;
      }*/

        IEnumerator CountDown()
        {
           
            while (TotalTime >= 0)
            {
                timerText.text = TotalTime.ToString("f2");
                yield return new WaitForSeconds(1);
                TotalTime--;
                if (finnish)
                {
                    break;
                }
            }
        if (TotalTime <= 0)
        {
            timerText.text = "you lose";
        }
        }
  
    public void Finnish()
        {
        finnish = true;
        timerText.color = Color.yellow;
        }
  
}
