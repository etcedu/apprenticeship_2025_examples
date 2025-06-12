using UnityEngine;
using TMPro;
using Unity.Properties;
using UnityEngine.UIElements;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private void Awake()
    {
        instance = this;
        //spawn the player
        Instantiate(playerPrefab, transform.position, transform.rotation);
    }

    public int score;
    public int lives;
    public GameObject gameOverPanel;
    public TextMeshProUGUI scoreText, livesText;
    public GameObject playerPrefab;
    public GameObject explosionPrefab;

    public void KillEnemy(Vector3 position)
    {
        score += 10;
        scoreText.text = "" + score;
        Instantiate(explosionPrefab, position, Quaternion.identity);
    }

    public void KillPlayer(Vector3 position)
    {
        Instantiate(explosionPrefab, position, Quaternion.identity);

        //If we have lives left, update lives and respawn
        if (lives > 0)
        {
            //decrease lives
            lives--;
            //update lives text
            livesText.text = lives + " Lives";
            //respawn the player
            Instantiate(playerPrefab, transform.position, transform.rotation);
        }
        //otherwise, game over
        else
        {
            gameOverPanel.SetActive(true);
        }
    }
}
