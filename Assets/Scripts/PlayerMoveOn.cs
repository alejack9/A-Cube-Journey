using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveOn : MonoBehaviour
{
    public Rigidbody rb;
    public float fowardForce = 2000f;
    void FixedUpdate()
    {
        // add a force of 2000 on the z-azis (deltaTime is the time passed since the last update - it's usefull for give the same behaviour in all PCs)
        rb.AddForce(0, 0, fowardForce * Time.deltaTime);
    }
}
