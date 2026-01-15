using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public int score;
    public float survivedTime;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    private void Update()
    {
        survivedTime += Time.deltaTime;
    }

    public void AddScore(int amount)
    {
        score += amount;
    }
}
