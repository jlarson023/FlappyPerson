using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Death variable
    public bool gameOver = false;
    
    //jumping
    public float jumpForce;
    public KeyCode jumpKey;
    private Rigidbody rb;

    //Animation
    private Animator animator;

    //Particles
    public ParticleSystem boosterFlames;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(jumpKey) && !gameOver)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
     if (collision.gameObject.CompareTag("wall"))
        {
            gameOver = true;
            animator.SetBool("gameOver", gameOver);
        }   
    }

}
