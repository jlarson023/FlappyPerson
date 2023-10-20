using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float moveSpeed;
    public float leftBound;
    private PlayerController pc;

    // Start is called before the first frame update
    void Start()
    {
        pc = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (pc.gameOver == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * moveSpeed);
        }
        if (transform.position.x < leftBound && (gameObject.CompareTag("Obstacle") || gameObject.CompareTag("House")))
        {
            Destroy(gameObject);
        }
    }
}
