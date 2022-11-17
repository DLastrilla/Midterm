using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BastaScript : MonoBehaviour
{

    // Start is called before the first frame update
    public float speed;
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

     void FixedUpdate()
    {
        float movementHorizontal = Input.GetAxis("Horizontal");
        float movementVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(movementVertical, 0.0f, movementHorizontal);
        rb.AddForce(movement * speed);
    }

}
