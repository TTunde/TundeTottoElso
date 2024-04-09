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
        Vector2 cameraSize = new Vector2(camera.orthographicSize * camera.aspect, camera.orthographicSize);
        //cameraSize *= 2;

        Rect cameraRect = new Rect(cameraCenter - cameraSize, cameraSize * 2);
        Bounds objBounds = collider2D.bounds;

        float yJump = (cameraSize.y * 2 + objBounds.size.y);
        float xJump = (cameraSize.x * 2 + objBounds.size.x);

        if (objBounds.min.y > cameraRect.yMax)
        {
            transform.position += Vector3.down * yJump; //new Vector3(0, - objectBounds.size,y, 0) ez is lehetett volna
            Physics2D.SyncTransforms();
        }

        if (objBounds.max.y < cameraRect.yMin)
        {
            transform.position += Vector3.up * yJump; //new Vector3(0, - objectBounds.size,y, 0) ez is lehetett volna
            Physics2D.SyncTransforms();
        }
        
        if (objBounds.min.x > cameraRect.xMax)
        {
            transform.position += Vector3.left * xJump; //new Vector3(0, - objectBounds.size,y, 0) ez is lehetett volna
            Physics2D.SyncTransforms();
        }

        if (objBounds.max.x < cameraRect.xMin)
        {
            transform.position += Vector3.right * xJump; //new Vector3(0, - objectBounds.size,y, 0) ez is lehetett volna
            Physics2D.SyncTransforms();
        }


    }
    private void OnDrawGizmos()
    {
        if (collider2D == null) return; // referenciatípusok lehetnek null értékûek    
        Bounds bounds = collider2D.bounds; // ez a típus egyhatár - befoglaló tégletest
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireCube(bounds.center, bounds.size);

    }
}
