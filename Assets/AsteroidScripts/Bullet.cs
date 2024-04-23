using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] float Speed;
    [SerializeField] float lifeTime = 2;
    [SerializeField] int damage = 25;
    float time;


    private void Start()
    {
       // time = lifeTime;
        //Destroy(gameObject, lifeTime);
        //Invoke("DestroySelf", lifeTime);// t�rt�njen meg "valami", k�sleltetve ---param�tern�lk�li met�dusokkal m�k�dik csak
        Invoke(nameof(DestroySelf), lifeTime); // �gy �rdemes haszn�lni az invoke-ot, mert kisebb a hibalehet�s�g a string hi�nya miatt
    }
    private void Update()
    {
        transform.position += transform.right * Speed * Time.deltaTime;
        //DestroyObjectDelayed();
        //time -= Time.deltaTime;
        //if (time <=0)
        //{
        //    Destroy(gameObject); //this-el csak ezt a scriptet puszt�tom
        //}
    }

    //void DestroyObjectDelayed()
    //{
    //    // Kills the game object in 2 seconds after loading the object
    //    Destroy(gameObject, lifeTime);
    //}

    void DestroySelf()
    {
        Destroy(gameObject);    
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(other.name);
        HealthObject healthObject = other.GetComponent<HealthObject>(); //ha nem tal�l semmit akkor NULL �rt�ket ad vissza
        if (healthObject != null)
        {
            healthObject.Damage(damage);
            Destroy(gameObject);
        }
    }
}
