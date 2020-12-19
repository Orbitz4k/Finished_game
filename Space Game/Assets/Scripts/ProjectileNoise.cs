using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileNoise : MonoBehaviour
{
    [SerializeField] AudioSource enemyAudio;
    public AudioClip Boom;
    // Start is called before the first frame update
    void Start()
    {
        enemyAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //Makes explosion noise when enemies are destroyed
    public void makeBoomNoise()
    {
        enemyAudio.PlayOneShot(Boom, 1.0f);
    }
}
