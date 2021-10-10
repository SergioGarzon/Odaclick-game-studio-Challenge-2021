using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChargeLevel : MonoBehaviour
{
    public DataLevelObjects dataLevel;

    public void ChargeObjectProperty(int value)
    {
        switch(value)
        {
            case 1: DataSave(100, 1.5f, 2); break;
            case 2: DataSave(200, 1f, 4); break;
            case 3: DataSave(300, 0.5f, 6); break;
        }
    }

    private void DataSave(int value1, float value2, int value3)
    {
        dataLevel.spawnObject = value1;
        dataLevel.timeSpawn = value2;
        dataLevel.cantObjectSpawn = value3;
    }
}
