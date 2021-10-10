using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Autodestroy : MonoBehaviour
{
    public ScorePlayer scorePlayerScript; 
    
    private PointsCounter pointsCounter;    
    private GameController gameController;


    void Start()
    {
        pointsCounter = GameObject.Find("ObjectManager").GetComponent<PointsCounter>();
        gameController = GameObject.Find("ObjectManager").GetComponent<GameController>();
        //No me lo esta cargando, acordarse de verificar porque
        //scorePlayerScript = Resources.Load<ScorePlayer>("Script/Logic/ScorePlayer");
        
        StartCoroutine(QuitObjectScene());
    }


    IEnumerator QuitObjectScene()
    {
        yield return new WaitForSeconds(5);
        DestroyObjectGame();
    }

    private void DestroyObjectGame()
    {
        if (this.gameObject != null)
        {
            if (scorePlayerScript.score >= 0 && scorePlayerScript.score <= 100 && gameController.getControlData())
            {
                switch (this.gameObject.tag)
                {
                    case "Shield": scorePlayerScript.score -= 5; break;
                    case "TargetMark": scorePlayerScript.score -= 10; break;
                    default: scorePlayerScript.score -= 1; break;
                }

                Destroy(this.gameObject);

                pointsCounter.UpdatePointsScene();
            }

        }
    }

}
