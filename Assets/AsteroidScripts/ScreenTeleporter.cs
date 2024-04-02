using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenTeleporter : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    new Collider2D collider2D;
    new Camera camera;

    private void Start()
    {
        camera = Camera.main;
        spriteRenderer = GetComponent<SpriteRenderer>(); //generikus függvény, megmondjuk milyen típust keresünk és azzal tér vissza
        collider2D = GetComponent<Collider2D>();
    }

    private void Update()
    {
        //--- kamera belátott tere
        Vector2 cameraCenter = camera.transform.position;
        Vector2 cameraSize = new Vector2(camera.orthographicSize*camera.aspect, camera.orthographicSize);
        Rect cameraRet = new Rect(cameraCenter - cameraSize, cameraSize *2);

        Bounds objBounds = collider2D.bounds;

    }
    private void OnDrawGizmos()
    {
        if (collider2D == null) return; // referenciatípusok lehetnek null értékûek    
        Bounds bounds = collider2D.bounds; // ez a típus egyhatár - befoglaló tégletest
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireCube(bounds.center, bounds.size);
        
    }
}
