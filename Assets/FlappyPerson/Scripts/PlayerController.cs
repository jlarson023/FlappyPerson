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
    public ParticleSystem booster;
    //Sound
    private AudioSource playerAudio;
    public AudioClip jumpSound;
    public AudioClip crashSound;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
        playerAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(jumpKey) && !gameOver)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            playerAudio.PlayOneShot(jumpSound, 1.0f);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
     if (collision.gameObject.CompareTag("wall"))
        {
            gameOver = true;
            animator.SetBool("gameOver", gameOver);
            booster.Stop();
            playerAudio.PlayOneShot(crashSound, 1.0f);

        }
     if (collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("Game Over");
            gameOver = true;
            animator.SetBool("gameOver", gameOver);
            booster.Stop();
            playerAudio.PlayOneShot(crashSound, 1.0f);
        }
    }

}
