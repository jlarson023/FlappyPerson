using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerHouses : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 spawnPos;
    private float startDelay = 1.0f;
    private float repeatRate = 3.0f;
    private PlayerController playerControllerScript;

    // Start is called before the first frame update
    void Start()
    {
        spawnPos = transform.position;
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
    }

    void SpawnObstacle()
    {
        if (playerControllerScript.gameOver == false)
        {
            Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}