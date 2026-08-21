using UnityEngine;

public class ElectronOrbit : MonoBehaviour
{
    public Transform center;

    public float radiusX = 5f;
    public float radiusY = 2.5f;
    public float speed = 300f;

    public float startAngle = 0f;

    private float angle;

    void Start()
    {
        angle = startAngle;
    }

    void Update()
    {
        angle += speed * Time.deltaTime;

        float x = center.position.x + radiusX * Mathf.Cos(angle * Mathf.Deg2Rad);
        float y = center.position.y + radiusY * Mathf.Sin(angle * Mathf.Deg2Rad);

        transform.position = new Vector2(x, y);
    }
}