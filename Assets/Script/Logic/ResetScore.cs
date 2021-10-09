using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetScore : MonoBehaviour
{
    public ScorePlayer scorePlayerData;

    public void ResetScoreDataNew()
    {
        scorePlayerData.score = 50;
    }
}
