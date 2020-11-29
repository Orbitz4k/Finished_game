using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisions : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.CompareTag("TicTac"))
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
            GameObject.Find("Game Manager").GetComponent<GameManager>().AddScore(1);
        }
        else if (other.gameObject.CompareTag("Player"))
        {
            GameObject.Find("Game Manager").GetComponent<GameManager>().gameOver = true;
        }
    }
}
