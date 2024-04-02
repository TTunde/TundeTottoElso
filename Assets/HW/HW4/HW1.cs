using UnityEngine;

public class HW1 : MonoBehaviour
{
    /*
     - **Lépkedés**
    Írj komponenst, aminek a kurzorgombok lenyomásakor lépked 1 egységet a megfelelõ irányba!
     */

    float xInput;
    float yInput;
    float moveSpeed = 4;
    Vector3 velocity;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
            transform.position += Vector3.right;
        if (Input.GetKeyDown(KeyCode.LeftArrow))
            transform.position += Vector3.left;

        if (Input.GetKeyDown(KeyCode.UpArrow))
            transform.position += Vector3.up;
        if (Input.GetKeyDown(KeyCode.DownArrow))
            transform.position += Vector3.down;
        // Movement();
    }

    private void Movement()
    {
        xInput = Input.GetAxisRaw("Horizontal");
        yInput = Input.GetAxisRaw("Vertical");

        if (Input.GetKeyDown(KeyCode.RightArrow) ||
            Input.GetKeyDown(KeyCode.LeftArrow) ||
            Input.GetKeyDown(KeyCode.UpArrow) ||
            Input.GetKeyDown(KeyCode.DownArrow))
        {
            Vector3 move = new Vector3(xInput, yInput);
            transform.position += move * moveSpeed * Time.deltaTime;

        }

    }
    /*
     using UnityEngine;

    public class Jumper : MonoBehaviour
    {
    [SerializeField] KeyCode rightKey = KeyCode.RightArrow;
    [SerializeField] KeyCode leftKey = KeyCode.LeftArrow;
    [SerializeField] KeyCode upKey = KeyCode.UpArrow;
    [SerializeField] KeyCode downKey = KeyCode.DownArrow;

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.RightArrow))
                transform.position += Vector3.right;
            if (Input.GetKeyDown(leftKey))
                transform.position += Vector3.left;
            if (Input.GetKeyDown(upKey))
                transform.position += Vector3.up;
            if (Input.GetKeyDown(downKey))
                transform.position += Vector3.down;
        }
    }

     */


}
