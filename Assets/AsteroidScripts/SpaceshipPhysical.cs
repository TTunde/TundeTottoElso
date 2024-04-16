using UnityEngine;

public class SpaceshipPhysical : MonoBehaviour
{
    [SerializeField] float maxSpeed = 5;       // m/s
    [SerializeField] float acceleration = 5;   // m/s^2
    [SerializeField] float angularSpeed = 180;

    [SerializeField] Rigidbody2D rigidBody;

    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.R))
        //{
        //    Physics2D.gravity = -Physics2D.gravity; // ezzel gombnyomásra meg lehet változtatni a gravitációt
        //}
        // Input
        float x = Input.GetAxisRaw("Horizontal");

        // Forgatás
        rigidBody.angularVelocity = 0;
       // transform.Rotate(0, 0, angularSpeed * -x * Time.deltaTime);
        rigidBody.rotation += angularSpeed * -x * Time.deltaTime;
    }

    void FixedUpdate()
    {
        // Input
        float yInput = Input.GetAxisRaw("Vertical");

        Vector2 velocity = rigidBody.velocity;

        // Gyorsítás
        velocity += (Vector2)transform.up * acceleration * yInput * Time.fixedDeltaTime;  // ??

        // Max sebesség
        velocity = Vector3.ClampMagnitude(velocity, maxSpeed);

        rigidBody.velocity = velocity;
    }
}
