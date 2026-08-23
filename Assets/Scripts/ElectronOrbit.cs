using UnityEngine;

public class ElectronOrbit : MonoBehaviour
{
    public Transform center;

    public float radiusX = 5f;
    public float radiusY = 2.5f;

    public float speed = 100f;

    public float startAngle = 0f;

    public float rotation = 0f;

    public SpriteRenderer sr;
    public int nucleusOrder = 10;
    public int frontOffset = 5;
    public int backOffset = 5;

    private float angle;

    void Start()
    {
        angle = startAngle;
        if (sr == null) sr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        angle += speed * Time.deltaTime;

        float elipX = radiusX * Mathf.Cos(angle * Mathf.Deg2Rad);
        float elipY = radiusY * Mathf.Sin(angle * Mathf.Deg2Rad);

        float rotRad = rotation * Mathf.Deg2Rad;

        float x = elipX * Mathf.Cos(rotRad) - elipY * Mathf.Sin(rotRad);
        float y = elipX * Mathf.Sin(rotRad) + elipY * Mathf.Cos(rotRad);

        transform.position = new Vector2(center.position.x + x, center.position.y + y);
        if (Mathf.Sin(angle * Mathf.Deg2Rad) > 0f)
        {
            sr.sortingOrder = nucleusOrder - backOffset;
        }
        else
        {
            sr.sortingOrder = nucleusOrder + frontOffset;
        }
    }
}
