using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsCounter : MonoBehaviour
{
    public Text txtPointer;    
    public Text txtCantObject;

    public ScorePlayer score;

    void Start()
    {
        UpdatePointsScene();
    }

    public void UpdatePointsScene()
    {
        txtPointer.text = score.score.ToString();
    }

    public void UpdateCantObjectSpawn(int count)
    {
        txtCantObject.text = count.ToString();
    }



}
