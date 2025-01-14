using UnityEngine;

public class PlayerMovememnnt : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [SerializeField] private float speed = 5f;
    private float moveX = 0f; // Horizontal movement
    private float moveY = 0f; // Vertical movement


    private void Update()
    {
        HandleMovement();
    }

    private void HandleMovement()
    {
        // Reset movement inputs
        moveX = 0f;
        moveY = 0f;

        // Get input for movement
        if (Input.GetKey(KeyCode.W)) moveY = 1f;
        if (Input.GetKey(KeyCode.S)) moveY = -1f;
        if (Input.GetKey(KeyCode.A)) moveX = -1f;
        if (Input.GetKey(KeyCode.D)) moveX = 1f;

        // Normalize movement
        float magnitude = Mathf.Sqrt((moveX * moveX) + (moveY * moveY));
        if (magnitude > 1f)
        {
            moveX /= magnitude;
            moveY /= magnitude;
        }

        // Apply movement
        transform.position += new Vector3(moveX, moveY, 0) * speed * Time.deltaTime;
    }
}
