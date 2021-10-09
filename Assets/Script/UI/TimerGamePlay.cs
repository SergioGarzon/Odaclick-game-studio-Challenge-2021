using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerGamePlay : MonoBehaviour
{
    [SerializeField]
    private int minutes;

    [SerializeField]
    private int second;

    [SerializeField]
    private Text txtTimeData;

    private int min, sec;

    private GameController gameController;


    private void Start()
    {
        gameController = gameObject.GetComponent<GameController>();
    }

    public void StartTimer()
    {
        min = minutes;
        sec = second;

        writeTimer(min, sec);
        Invoke("updateTimer", 1f);
    }

    public void stopTimer()
    {
        CancelInvoke();
    }

    private void updateTimer()
    {
        sec--;

        if(sec < 0)
        {
            if(min == 0)
            {
                gameController.disabledPanel();
            } 
            else
            {
                min--;
                sec = 59;
            }
        }

        writeTimer(min, sec);
        Invoke("updateTimer", 1f);
    }


    private void writeTimer(int minute, int seg)
    {
        if(seg < 10)
        {
            txtTimeData.text = minute.ToString() + ":0" + seg.ToString();
        }
        else
        {
            txtTimeData.text = minute.ToString() + ":" + seg.ToString();
        }
    }











}
