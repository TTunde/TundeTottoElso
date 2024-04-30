using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HealthObject : MonoBehaviour
{

    [SerializeField] int startHp;
    [SerializeField] int collisionDamage;
    [SerializeField] SpriteRenderer mySpriteRenderer;
    [SerializeField] List<Sprite> mySprites;

    [SerializeField] TMP_Text hpText;
    int currentHp;
    bool isSetup = false;

    private void OnValidate()
    {
        if (mySpriteRenderer == null)
            mySpriteRenderer = GetComponent<SpriteRenderer>();
    }
    void Start()
    {
        currentHp = startHp;
        isSetup = true;
        UpdateHealthText();
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        Damage(collisionDamage);
    }
    public void Damage(int damage)
    {
        if (!isSetup) return;
        if (damage < 0) return;

        currentHp -= damage;
        UpdateHealthText();
        UpdateSprite();

        if (currentHp <= 0)
            Destroy(gameObject);
    }
    void UpdateSprite() 
    {
        if (mySpriteRenderer == null) return;
        if (mySprites == null || mySprites.Count == 0) return;

        float healtRate = (float)currentHp / startHp; //0-1-ig terjedõ érték
        healtRate = 1 - healtRate; // 1-0
        int index = Mathf.RoundToInt(healtRate * (mySprites.Count - 1)); // (mySprites.Count - 1)  - 0 
        mySpriteRenderer.sprite = mySprites[index];

    }
    private void UpdateHealthText()
    {
        if (hpText != null)
        {
            hpText.text = "Health: " + currentHp;
        }
    }




}
