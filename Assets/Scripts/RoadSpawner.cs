using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadSpawner : MonoBehaviour
{
    
    public GameObject road;
    Vector3 nextSpawnpoint;


    public void SpawnTile()
    {
        GameObject temp = Instantiate(road,nextSpawnpoint,Quaternion.identity);
        nextSpawnpoint = temp.transform.GetChild(1).transform.position;
    }

    void Start()
    {
        for (int i = 0; i < 30; i++)
        {
            SpawnTile();
        }

    }


}
