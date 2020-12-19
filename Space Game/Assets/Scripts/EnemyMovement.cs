using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] float zDestroy = -30.0f;
    public float speed = 5.0f;
    [SerializeField] Rigidbody objectRb;
    // Start is called before the first frame update
    void Start()
    {
        objectRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //Moves the enemies fowards and rotates enemies and destoys if out of bounds 
        objectRb.AddForce(Vector3.forward * -speed);
        objectRb.transform.Rotate(0.25f, 0.25f, 0.0f);
        if(transform.position.z < zDestroy)
        {
            Destroy(gameObject);
        }
    }
}
