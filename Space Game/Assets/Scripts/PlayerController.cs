using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 20.0f;
    public float delay = 0.25f;
    public float timer;
    [SerializeField] Rigidbody playerRb;
    public GameObject projectile;
    [SerializeField] AudioSource playerAudio;
    public AudioClip Zap;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        playerAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //Lets the player shoot the projectile and also plays the projectile noise
        if (GameObject.Find("Game Manager").GetComponent<GameManager>().gameOver == false) {
            MovePlayer();
            if (Time.time >= timer && (Input.GetKeyDown(KeyCode.Space)))
            {
                Instantiate(projectile, transform.position, projectile.transform.rotation);
                timer = Time.time + delay;
                playerAudio.PlayOneShot(Zap, 1.0f);
            }
        }
    }
    void MovePlayer()
    {
        //Allows the player to move left and right
        float horizontalInput = Input.GetAxis("Horizontal");
        playerRb.AddForce(Vector3.right * speed * horizontalInput);
    }
}
