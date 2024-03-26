using UnityEngine;

public class Spaceship : MonoBehaviour
{

    [SerializeField] float speed = 5;
    private void Update()
    {
        float x = Input.GetAxisRaw("Horizontal"); //-1 �s 1 k�z�tti �rt�ket k�rdezek le, de ha RAW-t rakunk mell� akkor 0 v 1
        float y = Input.GetAxisRaw("Vertical");

        Vector3 direction = new(x, y, 0);
        direction.Normalize();
        Vector3 step = direction * speed * Time.deltaTime;
        transform.position += step;

        //step *= Time.deltaTime;
        //step *= speed;

        //Vector2 position = transform.position;
        //Vector2 newPosition = position + step;
        //transform.position = newPosition;

        //----elforgat�s
        //Vector3 rot = transform.rotation.eulerAngles;


    }
}
