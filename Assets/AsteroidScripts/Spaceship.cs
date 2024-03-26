using UnityEngine;

public class Spaceship : MonoBehaviour
{

    [SerializeField] float speed = 5;
    private void Update()
    {
        float x = Input.GetAxisRaw("Horizontal"); //-1 és 1 közötti értéket kérdezek le, de ha RAW-t rakunk mellé akkor 0 v 1
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

        //----elforgatás
        //Vector3 rot = transform.rotation.eulerAngles;


    }
}
