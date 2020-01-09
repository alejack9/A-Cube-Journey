using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float sidewayForce = 500f;

    private bool moveRight = false;
    private bool moveLeft = false;

    // It's better using FixedUpdate when using physics
    void FixedUpdate()
    {
        var rb = GetComponent<Rigidbody>();
        if (moveRight)
        {
            rb.AddForce(sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            moveRight = false;
        }
        if (moveLeft)
        {
            rb.AddForce(-sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            moveLeft = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
            moveRight = true;
        if (Input.GetKey(KeyCode.LeftArrow))
            moveLeft = true;
    }
}
