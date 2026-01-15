using UnityEngine;
using UnityEngine.SceneManagement;

public class WinConditionManager : MonoBehaviour
{
    public float winTime = 120f;
    public int winScore = 300;

    private bool hasWon = false;

    void Update()
    {
        if (hasWon) return;

        if (GameManager.Instance.survivedTime >= winTime ||
            GameManager.Instance.score >= winScore)
        {
            Win();
        }
    }

    void Win()
    {
        hasWon = true;
        Debug.Log("Player Won!");
        SceneManager.LoadScene("WScene");
    }
}
