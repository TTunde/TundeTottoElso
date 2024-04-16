using UnityEngine;

public class Spaceship : MonoBehaviour
{

    [SerializeField] float maxSpeed = 5;
    [SerializeField] float angularSpeed = 180; //fordulási szög
    [SerializeField] float accelerate = 10; //gyorsulás
    [SerializeField] float drag = 0.5f; //


    Vector3 velocity; //sebesség

    private void Start()
    {
       // rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        float x = Input.GetAxisRaw("Horizontal"); //-1 és 1 közötti értéket kérdezek le, de ha RAW-t rakunk mellé akkor 0 v 1

        Vector3 step = velocity * Time.deltaTime; // kivettük a speedet , mozgás
        transform.position += step; // mozgás


        transform.Rotate(0, 0, angularSpeed * x * Time.deltaTime * -1); //vagy lehet itt -x is de akkor nem kell -1-el szorozni
    }

    private void FixedUpdate()//gyorsítást, lassítást érdemes ide rakni
    {
        if (Input.GetKeyDown(KeyCode.Space))// erre nem jó a fixedupdate mert pillanatszerû
        {
            Debug.Log("Bumm");
        }

        float y = Input.GetAxisRaw("Vertical");



        velocity += transform.up * y * accelerate * Time.fixedDeltaTime; //gyorsítás

        //Lassítás (közegellenállás)
        Vector3 dragVector = -velocity * drag;
        velocity += dragVector * Time.fixedDeltaTime;

        velocity = Vector3.ClampMagnitude(velocity, maxSpeed); // max sebesség
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
        //ez nem múködik 2 D-ben

        //float rotation2D = transform.rotation.eulerAngles.z; //3D - bõl 2 Dbe
        /* if (direction != Vector3.zero)
         {
             float rotation2D = transform.rotation.eulerAngles.z; //3D - bõl 2 Dbe
             float targetRotation = -Mathf.Atan2(direction. x,direction.y) * MathfRad2Deg; //mekkora szöget zár be és összehasonlítjuk a második paraméterrel
             float nextRotation = Mathf.MoveTowardsAngle(rotation2D, targetRotation, angularSpeed * Time.deltaTime); // megteszi a legrövidebb utat
             transform.rotation = Quaternion.Euler(0,0,nextRotation); // 2Dbõl 3Dbe - ez legyárt nekünk egy quaterniont
         }
        */

        //step *= Time.deltaTime;
        //step *= speed;

        //Vector2 position = transform.position;
        //Vector2 newPosition = position + step;
        //transform.position = newPosition;

        //----elforgatás
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

        // Mozgás
        Vector3 step = velocity * Time.deltaTime;
        transform.position += step;

        // Forgatás
        transform.Rotate(0, 0, angularSpeed * -x * Time.deltaTime);
    }

    void FixedUpdate()
    {
        // Input
        float y = Input.GetAxisRaw("Vertical");

        // Gyorsítás
        velocity += transform.up * acceleration * y * Time.fixedDeltaTime;

        // Lassítás (Közegellenállás)
        Vector3 dragVector = -velocity * drag;
        velocity += dragVector * Time.fixedDeltaTime;

        // Max sebesség
        velocity = Vector3.ClampMagnitude(velocity, maxSpeed);
    }
}

         */
    }
}
