using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float playerSpeed = 5f;
    public float velocity = 5f;
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 move = Vector2.zero;

        if (Input.GetKey(KeyCode.A))
        {
            move = Vector2.up;
        }

        if (Input.GetKey(KeyCode.D))
        {
            move = Vector2.down;
        }
        
        rb.linearVelocity = move * velocity;
    }
}
