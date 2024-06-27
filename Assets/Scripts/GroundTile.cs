using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundTile : MonoBehaviour
{

    RoadSpawner roadspawner;
    public GameObject wallPrefab;


    // Start is called before the first frame update
    void Start()
    {
        roadspawner = GameObject.FindObjectOfType<RoadSpawner>();
        SpawnWall();
    }
    private void OnTriggerExit(Collider other)
    {
        roadspawner.SpawnTile();
        Destroy(gameObject,2);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    
    void SpawnWall()
    {
        int wallspawnindex = Random.Range(2, 9);
        if(wallspawnindex >=2&&wallspawnindex<5 )
        {
            Transform spawnpoint = transform.GetChild(wallspawnindex).transform;
            Instantiate(wallPrefab, spawnpoint.position, Quaternion.identity, transform);
        }

    }
}
