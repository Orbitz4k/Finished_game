﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyProjectile : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Destroys projectile if out of bounds
        if (transform.position.z > 25)
        {
            Destroy(gameObject);
        }
    }
}
