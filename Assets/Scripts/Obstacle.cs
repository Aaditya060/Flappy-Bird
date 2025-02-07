using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float speed = 10f;
    void Update()
    {
        if (GameManager.instance.isGameOver == false)
        {
            transform.Translate(Vector2.left * Time.deltaTime * speed);
        }

    }
}
