using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;
    public float forwardForce = 4500f;
    public float sideForce = 50f;

	// Use this for initialization
	void Start ()
	{
        rb.AddForce(0, 0, forwardForce);
	}

    // Update is called once per frame
    void FixedUpdate () {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(0, (sideForce * Time.deltaTime) / 2, 0, ForceMode.VelocityChange);
        }
    }
}
