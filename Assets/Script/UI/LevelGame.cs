using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelGame : MonoBehaviour
{
    private string infoLevel;
    public Text txtInfoLevel;

    private void Start()
    {
        infoLevel = "";
    }

    public void InformationLevel(int value)
    {
        switch(value)
        {
            case 1: infoLevel = "Objetos a spawnear 10. Tiempo de Spaw: 3s.\n" +
                    "Objetos Moneda y Esfera Azul"; break;
            case 2: infoLevel = "Objetos a spawnear 25. Tiempo de Spaw: 2s.\n" +
                    "Objetos Moneda, esfera Azul, bloque amarillo y caja roja"; break;
            case 3: infoLevel = "Objetos a spawnear 40, Tiempo de Spaw: 1s\n" +
                    "Objetos Moneda, esfera Azul, bloque amarillo, caja roja,\n" +
                    "escudo y marca de target"; break;

        }

        txtInfoLevel.text = infoLevel;
    }

    public void setText()
    {
        txtInfoLevel.text = "";
    }

}
