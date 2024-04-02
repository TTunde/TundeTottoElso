using UnityEngine;

public class Spaceship : MonoBehaviour
{

    [SerializeField] float maxSpeed = 5;
    [SerializeField] float angularSpeed = 180; //fordul�si sz�g
    [SerializeField] float accelerate = 10; //gyorsul�s

    Vector3 velocity; //sebess�g

    private void Update()
    {
        float x = Input.GetAxisRaw("Horizontal"); //-1 �s 1 k�z�tti �rt�ket k�rdezek le, de ha RAW-t rakunk mell� akkor 0 v 1
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


        Vector3 step = velocity * Time.deltaTime; // kivett�k a speedet
        transform.position += step;

        transform.Rotate(0, 0, angularSpeed * x * Time.deltaTime * -1); //vagy lehet itt -x is de akkor nem kell -1-el szorozni

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


    }
}
