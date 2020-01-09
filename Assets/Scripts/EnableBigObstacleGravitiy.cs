using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableBigObstacleGravitiy : MonoBehaviour
{

    public float height = 8f;

    void Update()
    {
        var rb = GetComponent<Rigidbody>();
        if (rb.position.y >= height)
            rb.useGravity = true;
    }
}
