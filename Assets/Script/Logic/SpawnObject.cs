using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{    
    public GameObject[] objectToSpawn;
    public ScorePlayer score;    
    public DataLevelObjects dataLevel;

    public float delay;

    private PointsCounter pointCounter;
    private GameController gameController;
    private int countCreateSpawn;

    private bool control;

    private void Start()
    {
        gameController = GameObject.Find("ObjectManager").GetComponent<GameController>();
        pointCounter = GameObject.Find("ObjectManager").GetComponent<PointsCounter>();

        delay = dataLevel.timeSpawn;
        countCreateSpawn = 0;
        control = true;
        StartCoroutine(WaitToSpawn());
    }

    IEnumerator WaitToSpawn()
    {
        yield return new WaitForSeconds(delay);
        Spawn();
    }

    void Spawn()
    {
        if (control && score.score <= 100 && score.score >= 0 && gameController.getControlData() && countCreateSpawn < dataLevel.spawnObject)
        {
            Instantiate(objectToSpawn[Random.Range(0, dataLevel.cantObjectSpawn)],
            transform.position + new Vector3(Random.Range(0, 10), Random.Range(0, 10),0), transform.rotation);


            countCreateSpawn++;
            pointCounter.UpdateCantObjectSpawn(countCreateSpawn);
            StartCoroutine(WaitToSpawn());
        }        
    }

    
    public void CreateSpawnCoin()
    {
        int counter = 0;

        while(counter != 5 && countCreateSpawn < dataLevel.spawnObject)
        {
            Instantiate(objectToSpawn[0],
            transform.position + new Vector3(0, Random.Range(0, 10), Random.Range(0, 10)), transform.rotation);

            counter++;
            countCreateSpawn++;

            pointCounter.UpdateCantObjectSpawn(countCreateSpawn);
        }
        
    }

    public void setControl()
    {
        control = false;
    }
}
