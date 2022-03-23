using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public float acceleration;
    public float maxSpeed;

    private float direction;
    private new Rigidbody2D rigidbody2D;

    public GameObject oneShootPlatform;
    void Awake()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    } 

    // Update is called once per frame
    public void OnMove(InputAction.CallbackContext obj)
    {
        direction = obj.ReadValue<float>();
    }

    private void FixedUpdate()
    {
        var vector2 = new Vector2(direction, 0);
        if (rigidbody2D.velocity.sqrMagnitude < maxSpeed)
            rigidbody2D.AddForce(vector2 * acceleration);
    }
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Enemy");
            Die();
        }
        if (collider.gameObject.CompareTag("OneShootPlatform"))
        {
            Debug.Log("Trigger");
            DestroyPlatform();
        }
    }

    void Die()
    {
        Destroy(gameObject); // Détruit le player quand il entre dans un trigger
    }

    void DestroyPlatform()
    {
        Object.Destroy(oneShootPlatform);
    }
}


