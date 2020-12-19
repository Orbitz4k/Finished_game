using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisions : MonoBehaviour
{
    public ParticleSystem explosion;
    public AudioClip boom;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    //Allows for the FX to work
    private void enemyDeath()
    {
        Instantiate(explosion, transform.position, explosion.transform.rotation);
    }
    //For collisions
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.CompareTag("TicTac"))
        {
            other.gameObject.GetComponent<ProjectileNoise>().makeBoomNoise();
            Destroy(gameObject);
            Destroy(other.gameObject, 0.5f);
            GameObject.Find("Game Manager").GetComponent<GameManager>().AddScore(1);
            enemyDeath();
        }
        else if (other.gameObject.CompareTag("Player"))
        {
            GameObject.Find("Game Manager").GetComponent<GameManager>().gameOver = true;
            playerDeath();
            
        }

    }
    //Displays Fx on player death
    private void playerDeath()
    {
        Instantiate(explosion, transform.position, explosion.transform.rotation);
    }
}
