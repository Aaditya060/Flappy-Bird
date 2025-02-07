using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    public float force = 10;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            rb.linearVelocity =  Vector2.up * force;   
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log(collision.gameObject.tag);
        if (collision.gameObject.tag == "Obstacle" )
        {
            Debug.Log("Game Over");
            GameManager.instance.isGameOver = true;
            GameManager.instance.GameOverPanel.SetActive(true);
        }
    }
}
