using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsCounter : MonoBehaviour
{
    public Text txtPointer;
    public ScorePlayer score;

    void Start()
    {
        UpdatePointsScene();
    }

    public void UpdatePointsScene()
    {
        txtPointer.text = score.score.ToString();
    }

}
