using UnityEngine;

public class Spaceship : MonoBehaviour
{

    [SerializeField] float maxSpeed = 5;
    [SerializeField] float angularSpeed = 180; //fordulási szög
    [SerializeField] float accelerate = 10; //gyorsulás

    Vector3 velocity; //sebesség

    private void Update()
    {
        float x = Input.GetAxisRaw("Horizontal"); //-1 és 1 közötti értéket kérdezek le, de ha RAW-t rakunk mellé akkor 0 v 1
        float y = Input.GetAxisRaw("Vertical");



        velocity += transform.up * y * accelerate * Time.deltaTime;
        velocity = Vector3.ClampMagnitude(velocity, maxSpeed);
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


        Vector3 step = velocity * Time.deltaTime; // kivettük a speedet
        transform.position += step;

        transform.Rotate(0, 0, angularSpeed * x * Time.deltaTime * -1); //vagy lehet itt -x is de akkor nem kell -1-el szorozni

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


    }
}
