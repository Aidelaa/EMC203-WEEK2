using UnityEngine;

public class PowerUp : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        // Set a random color or any desired attribute for the collectible
        if (TryGetComponent(out Renderer renderer))
        {
            renderer.material.color = Color.red;
        }
    }

    // Triggered when another collider enters the power-up's collider
    private void OnTriggerEnter(Collider other)
    {
        // Check if the object colliding is tagged as "Player"
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject); // Destroy the power-up after collision
        }
    }
}

