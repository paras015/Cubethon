using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float ForwardForce = 500f;
    public float SideForce = 500f;
    public float JumpForce = 300f;
    public bool onGround = false;

    void FixedUpdate() {
        rb.AddForce(0, 0, ForwardForce * Time.deltaTime);
        if (Input.GetKey("d"))
        {
            rb.AddForce(SideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-SideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (onGround && Input.GetKey("space"))
        {
            rb.AddForce(0, JumpForce * Time.deltaTime, 0, ForceMode.VelocityChange);
            onGround = false;
        }
        if (rb.position.y < -2f)
        {
            FindObjectOfType<GameManager>().gameEnd();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name == "Ground")
        {
            onGround = true;
        }
    }
}
