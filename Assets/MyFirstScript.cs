using UnityEngine;

class MyFirstScript : MonoBehaviour
{
    [SerializeField] float speed;
    void Start()
    {
        Debug.Log("Hello unity");
        Debug.Log("First game " + name);
    }

    void Update()
    {
        transform.position += Vector3.up * speed * Time.deltaTime;    
    }


}
