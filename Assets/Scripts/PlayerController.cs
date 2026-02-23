using UnityEngine;
public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f;
    public float turnspeed;
    public float horizontalInput;
    public float forwardInput;
    Rigidbody rb;
     void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true; 
        rb.collisionDetectionMode = CollisionDetectionMode.Continuous; 
        rb.interpolation = RigidbodyInterpolation.Interpolate; 
    }
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
    }
    void FixedUpdate()
    {
        Vector3 move = transform.forward * forwardInput + transform.right * horizontalInput;
        move = move.normalized * speed;
        move.y = rb.linearVelocity.y;
        rb.linearVelocity = move;
    }
}
