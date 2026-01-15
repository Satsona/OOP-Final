using UnityEngine;
using TMPro;

public class GameplayUI : MonoBehaviour
{
    public TextMeshProUGUI timeText;
    public TextMeshProUGUI scoreText;

    void Update()
    {
        float time = GameManager.Instance.survivedTime;
        int score = GameManager.Instance.score;

        timeText.text = $"Time: {time:F1}s";
        scoreText.text = $"Score: {score}";
    }
}
