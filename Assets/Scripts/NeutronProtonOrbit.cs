using UnityEngine;

public class NeutronProtonOrbit : MonoBehaviour
{
    public Transform center;

    public float movementRadius = 4f;
    public float movementSpeed = 2f;
    public float changeTargetTime = 3f;

    private Vector2 targetPosition;
    private float timer;

    void Start()
    {
        targetPosition = transform.position;
        timer = changeTargetTime;
    }

    void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0f)
        {
            Vector2 randomOffset = Random.insideUnitCircle * movementRadius;

            targetPosition = new Vector2(
                center.position.x + randomOffset.x,
                center.position.y + randomOffset.y
            );

            timer = changeTargetTime;
        }

        transform.position = Vector2.Lerp(
            transform.position,
            targetPosition,
            movementSpeed * Time.deltaTime
        );
    }
}