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
        spriteRenderer = GetComponent<SpriteRenderer>(); //generikus f�ggv�ny, megmondjuk milyen t�pust keres�nk �s azzal t�r vissza
        collider2D = GetComponent<Collider2D>();
    }

    private void Update()
    {
        //--- kamera bel�tott tere
        Vector2 cameraCenter = camera.transform.position;
        Vector2 cameraSize = new Vector2(camera.orthographicSize*camera.aspect, camera.orthographicSize);
        Rect cameraRet = new Rect(cameraCenter - cameraSize, cameraSize *2);

        Bounds objBounds = collider2D.bounds;

    }
    private void OnDrawGizmos()
    {
        if (collider2D == null) return; // referenciat�pusok lehetnek null �rt�k�ek    
        Bounds bounds = collider2D.bounds; // ez a t�pus egyhat�r - befoglal� t�gletest
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireCube(bounds.center, bounds.size);
        
    }
}
