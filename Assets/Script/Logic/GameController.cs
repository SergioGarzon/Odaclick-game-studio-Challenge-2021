using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private TimerGamePlay timerGame;
    private PanelActive pnlActivate;
    private WinGameOverScript imgWinGameOver;

    private bool control;

    void Start()
    {
        timerGame = gameObject.GetComponent<TimerGamePlay>();
        pnlActivate = gameObject.GetComponent<PanelActive>();
        imgWinGameOver = gameObject.GetComponent<WinGameOverScript>();

        timerGame.StartTimer();

        control = true;
    }

    public void disabledPanel()
    {
        control = false;        
        pnlActivate.ChangePanel1();
        imgWinGameOver.EndGame();
    }

    public bool getControlData()
    {
        return control;
    }

}
