using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinGameOverScript : MonoBehaviour
{
    public Sprite imgWinGame;
    public Sprite imgGameOver;

    public Image imgGameFinal;

    public ScorePlayer playerLifeGame;

    public void EndGame()
    {
        if(playerLifeGame.score >= 100)        
            imgGameFinal.sprite = imgWinGame;        
        else        
            imgGameFinal.sprite = imgGameOver;
        
    }
   
}
