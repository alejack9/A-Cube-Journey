using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float sidewayForce = 500f;

    private Rigidbody rb;
    private bool moveRight = false;
    private bool moveLeft = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // It's better using FixedUpdate when using physics
    void FixedUpdate() {
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
        if (Input.GetKey("d"))
            moveRight = true;
        if (Input.GetKey("a"))
            moveLeft = true;

        if (rb.position.y < -0.7f)
            FindObjectOfType<GameManager>().GameOver();
    }
}
