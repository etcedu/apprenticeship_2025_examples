using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private void Awake()
    {
        instance = this;
    }

    public int score;
    public int lives;
    public TextMeshProUGUI scoreText;

    public void KilledEnemy()
    {
        score += 10;
        scoreText.text = "" + score;
    }

    public void KilledPlayer()
    {
        lives--;
    }
}
