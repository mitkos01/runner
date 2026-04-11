using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public float velocity = 7f;

    public MovePipe movePipe;

    private Rigidbody2D rb;
    public TMP_Text speedText;
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
        
        Vector2 targetVelocity = move * velocity;

        rb.linearVelocity = Vector2.Lerp(
            rb.linearVelocity,
            targetVelocity,
            5f * Time.fixedDeltaTime
        );
    }

    

    void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        //gameObject.SetActive(false);
        RestartGame();
        
    }
}
