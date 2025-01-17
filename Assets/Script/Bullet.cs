using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private Vector3 direction = Vector3.zero;
    [SerializeField] private float bulletSpeed = 10f; 

    // Sets the movement direction of the bullet
    public void SetDirection(Vector3 newDirection)
    {
        direction = newDirection.normalized; // Ensure the direction is normalized
    }

    // Sets the speed of the bullet
    public void SetBulletSpeed(float newBulletSpeed)
    {
        bulletSpeed = Mathf.Max(0, newBulletSpeed); // Prevent negative speed
    }

    private void Update()
    {
        // Only move the bullet if a direction is set
        if (direction != Vector3.zero)
        {
            transform.position += direction * bulletSpeed * Time.deltaTime;
        }
    }
}
