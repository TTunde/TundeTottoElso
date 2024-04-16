using UnityEngine;

public class Spaceship : MonoBehaviour
{

    [SerializeField] float maxSpeed = 5;
    [SerializeField] float angularSpeed = 180; //fordul�si sz�g
    [SerializeField] float accelerate = 10; //gyorsul�s
    [SerializeField] float drag = 0.5f; //


    Vector3 velocity; //sebess�g

    private void Start()
    {
       // rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        float x = Input.GetAxisRaw("Horizontal"); //-1 �s 1 k�z�tti �rt�ket k�rdezek le, de ha RAW-t rakunk mell� akkor 0 v 1

        Vector3 step = velocity * Time.deltaTime; // kivett�k a speedet , mozg�s
        transform.position += step; // mozg�s


        transform.Rotate(0, 0, angularSpeed * x * Time.deltaTime * -1); //vagy lehet itt -x is de akkor nem kell -1-el szorozni
    }

    private void FixedUpdate()//gyors�t�st, lass�t�st �rdemes ide rakni
    {
        if (Input.GetKeyDown(KeyCode.Space))// erre nem j� a fixedupdate mert pillanatszer�
        {
            Debug.Log("Bumm");
        }

        float y = Input.GetAxisRaw("Vertical");



        velocity += transform.up * y * accelerate * Time.fixedDeltaTime; //gyors�t�s

        //Lass�t�s (k�zegellen�ll�s)
        Vector3 dragVector = -velocity * drag;
        velocity += dragVector * Time.fixedDeltaTime;

        velocity = Vector3.ClampMagnitude(velocity, maxSpeed); // max sebess�g
        /*
         //if (velocity.magnitude > maxSpeed)
        //{
        //    velocity = velocity.normalized * maxSpeed;
        //}

        // direction.Normalize();
        // Debug.Log("TU: " + transform.up);
        // Debug.Log("VU: " + Vector3.up);
         */

        // direction.Normalize();



        //transform.rotation = Quaternion.LookRotation(direction);
        //ez nem m�k�dik 2 D-ben

        //float rotation2D = transform.rotation.eulerAngles.z; //3D - b�l 2 Dbe
        /* if (direction != Vector3.zero)
         {
             float rotation2D = transform.rotation.eulerAngles.z; //3D - b�l 2 Dbe
             float targetRotation = -Mathf.Atan2(direction. x,direction.y) * MathfRad2Deg; //mekkora sz�get z�r be �s �sszehasonl�tjuk a m�sodik param�terrel
             float nextRotation = Mathf.MoveTowardsAngle(rotation2D, targetRotation, angularSpeed * Time.deltaTime); // megteszi a legr�videbb utat
             transform.rotation = Quaternion.Euler(0,0,nextRotation); // 2Db�l 3Dbe - ez legy�rt nek�nk egy quaterniont
         }
        */

        //step *= Time.deltaTime;
        //step *= speed;

        //Vector2 position = transform.position;
        //Vector2 newPosition = position + step;
        //transform.position = newPosition;

        //----elforgat�s
        //Vector3 rot = transform.rotation.eulerAngles;

        /*----------------------------------------------------------------
         * using UnityEngine;

public class Spaceship : MonoBehaviour
{
    [SerializeField] float maxSpeed = 5;       // m/s
    [SerializeField] float acceleration = 5;   // m/s^2
    [SerializeField] float angularSpeed = 180;
    [SerializeField] float drag = 0.5f;        // ???

    Vector3 velocity;

    void Update()
    {
        // Input
        float x = Input.GetAxisRaw("Horizontal");

        // Mozg�s
        Vector3 step = velocity * Time.deltaTime;
        transform.position += step;

        // Forgat�s
        transform.Rotate(0, 0, angularSpeed * -x * Time.deltaTime);
    }

    void FixedUpdate()
    {
        // Input
        float y = Input.GetAxisRaw("Vertical");

        // Gyors�t�s
        velocity += transform.up * acceleration * y * Time.fixedDeltaTime;

        // Lass�t�s (K�zegellen�ll�s)
        Vector3 dragVector = -velocity * drag;
        velocity += dragVector * Time.fixedDeltaTime;

        // Max sebess�g
        velocity = Vector3.ClampMagnitude(velocity, maxSpeed);
    }
}

         */
    }
}
