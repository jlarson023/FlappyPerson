using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerObstacles : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 spawnPos;
    private float startDelay = 2.0f;
    private float repeatRate = 2.0f;
    private float bottom = 0.75f;
    private PlayerController playerControllerScript;

    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
    }

    void SpawnObstacle()
    {
        if(playerControllerScript.gameOver == false)
        {
            Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
        }    
        
    }

    // Update is called once per frame
    void Update()
    {
        spawnPos = new Vector3(transform.position.x, Random.Range(bottom, 8), transform.position.z);
    }
}
