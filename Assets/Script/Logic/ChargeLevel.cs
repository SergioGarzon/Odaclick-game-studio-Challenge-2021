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
            case 1: DataSave(10, 3, 2); break;
            case 2: DataSave(25, 2, 4); break;
            case 3: DataSave(40, 1, 6); break;
        }
    }

    private void DataSave(int value1, int value2, int value3)
    {
        dataLevel.spawnObject = value1;
        dataLevel.timeSpawn = value2;
        dataLevel.cantObjectSpawn = value3;
    }
}
