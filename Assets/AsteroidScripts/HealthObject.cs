using UnityEngine;

public class HealthObject : MonoBehaviour
{

    [SerializeField] int startHp;
    [SerializeField] int collisionDamage;
    int currentHp;

    void Start()
    {
        currentHp = startHp;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Damage(collisionDamage);
    }
    public void Damage(int damage)
    {
        damage = damage < 0 ? 0 : damage;
        currentHp -= damage;
        if (currentHp <= 0)
        {
            Destroy(gameObject);
        }
    }



}
