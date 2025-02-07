using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameObject ObstaclePrefab;
    public float timer = 0f;
    public bool isGameOver = false;
    public GameObject GameOverPanel;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        isGameOver = false;
        GameOverPanel.SetActive(false);
    }
    private void Update()
    {
        if (timer <= 0f)
        {
            if (isGameOver == false)
            {
                GameObject gm = Instantiate(ObstaclePrefab, new Vector3(2f, Random.Range(-2f, 1f), 0f), Quaternion.identity);
                Destroy(gm, 5f);
                timer = 3f;
            }
            
        }

        else
        {
            timer -= Time.deltaTime;
            
        }
    }

    public void RetryButton()
    {
        //isGameOver = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
