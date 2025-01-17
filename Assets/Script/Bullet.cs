using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float speed = 5f; // Bullet speed
    private Vector3 direction;

    private void Start()
    {
        // Set the initial movement direction based on the bullet's forward direction
        direction = transform.forward.normalized;
    }

    private void Update()
    {
        // Move the bullet forward in the specified direction
        transform.Translate(direction * speed * Time.deltaTime, Space.World);
    }
}
