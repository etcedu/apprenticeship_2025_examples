using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private void Awake()
    {
        instance = this;
        Instantiate(playerPrefab, transform.position, transform.rotation);
    }

    public int score;
    public int lives;
    public TextMeshProUGUI scoreText, livesText;
    public GameObject playerPrefab;
    public EnemySpawner spawner;
    public GameObject gameOverPanel;
    public GameObject explosionPrefab;

    public void KilledEnemy(Vector3 position)
    {
        Instantiate(explosionPrefab, position, Quaternion.identity);

        score += 10;
        scoreText.text = "" + score;
    }

    public void KilledPlayer(Vector3 position)
    {
        Instantiate(explosionPrefab, position, Quaternion.identity);

        lives--;
        livesText.text = lives + " Lives";

        if (lives > 0)
        {
            //destroy all the enemies
            //iterate through the indexes of every child of the spawner
            for (int i = spawner.transform.childCount - 1; i >= 0; i--)
            {
                //destroy that game object
                Destroy(spawner.transform.GetChild(i).gameObject);
            }

            //respawn the player
            Instantiate(playerPrefab, transform.position, transform.rotation);
        }
        else
        {
            //Game Over
            gameOverPanel.SetActive(true);
        }
    }
}
