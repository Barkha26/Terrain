using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateUnitColliders : MonoBehaviour
{

    public GameObject UnitCollider = null;
    public Vector3 unitPosition = new Vector3(-500, 0, -500);
    int zCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        //for (int j = -50; j < 50; j++)
        //{
        //    for (int i = -50; i < 50; i++)
        //    {
        //        unitPosition = new Vector3(i, 1, j);
        //        Instantiate(UnitCollider, unitPosition, Quaternion.identity);
        //    }
        //}

        for (int j = -5; j < 5; j++)
        {
            for (int i = -5; i < 5; i++)
            {
                unitPosition = new Vector3((i + 0.25f), 0f, (j + 0.25f));
                Instantiate(UnitCollider, unitPosition, Quaternion.identity);
                unitPosition = new Vector3((i + 0.75f), 0f, (j + 0.25f));
                Instantiate(UnitCollider, unitPosition, Quaternion.identity);
                unitPosition = new Vector3((i + 0.25f), 0f, (j + 0.75f));
                Instantiate(UnitCollider, unitPosition, Quaternion.identity);
                unitPosition = new Vector3((i + 0.75f), 0f, (j + 0.75f));
                Instantiate(UnitCollider, unitPosition, Quaternion.identity);
                zCount++;
            }
            zCount++;
        }
        Debug.Log(zCount);
    }
}
