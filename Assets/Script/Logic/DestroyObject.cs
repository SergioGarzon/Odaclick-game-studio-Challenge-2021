using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    public ScorePlayer scorePlayerScript;
        
    private PointsCounter pointsCounter;
    private SpawnObject spawnObject;
    private GameController gameController;

    private int contador;

    void Start()
    {
        pointsCounter = GameObject.Find("ObjectManager").GetComponent<PointsCounter>();
        spawnObject = GameObject.Find("ObjectScene").GetComponent<SpawnObject>();
        gameController = GameObject.Find("ObjectManager").GetComponent<GameController>();

        contador = 5;
    }

    void Update()
    {       
        
            if(scorePlayerScript.score >= 0 && scorePlayerScript.score < 100 && gameController.getControlData())
            {
                if (Input.GetKeyDown(KeyCode.Mouse0))
                {
                    Vector3 mouseWorldPosition = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,
                        Input.mousePosition.y, 100f));

                    Vector3 direction = mouseWorldPosition - Camera.main.transform.position;

                    RaycastHit hit;

                    if (Physics.Raycast(Camera.main.transform.position, direction, out hit, 100f))
                    {

                        switch (hit.collider.gameObject.tag)
                        {
                            case "Coin": Destroy(hit.collider.gameObject); scorePlayerScript.score += 5; break;
                            case "RedBox": Destroy(hit.collider.gameObject); scorePlayerScript.score -= 5; break;
                            case "BlueSphere": Destroy(hit.collider.gameObject); scorePlayerScript.score += 2; break;
                            case "TargetMark": spawnObject.CreateSpawnCoin(); Destroy(hit.collider.gameObject); break;
                            case "YellowBlock": Destroy(hit.collider.gameObject); scorePlayerScript.score += 1; break;
                            case "Shield":
                                if (this.gameObject != null)
                                {
                                    contador--;

                                    if (contador == 0)
                                    {
                                        Destroy(hit.collider.gameObject);
                                        scorePlayerScript.score += 10;
                                        contador = 5;
                                    }
                                }
                                else
                                {
                                    contador = 5;
                                }

                                break;
                        }

                        pointsCounter.UpdatePointsScene();

                    }
                }
            }
            else
            {
                gameController.disabledPanel();
            }
           
    
    }




}
