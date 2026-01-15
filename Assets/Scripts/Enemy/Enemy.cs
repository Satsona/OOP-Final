using UnityEngine;

public class Enemy : MonoBehaviour, IDamageable
{
    public Transform player;
    public float speed = 2f;
    public float attackRange = 1.2f;
    public int health = 3;

    private BaseState currentState;

    void Start()
    {
        currentState = new ChaseState(this);

    }

    void Update()
    {
        currentState.Execute();

        if (player == null)
        {
            Debug.LogError("Player reference missing!", this);
            return;
        }
    }

    public void ChangeState(BaseState newState)
    {
        currentState = newState;
    }

    public void MoveTowardsPlayer()
    {
        Vector2 dir = (player.position - transform.position).normalized;
        transform.Translate(dir * speed * Time.deltaTime);
    }

    public bool IsInAttackRange()
    {
        return Vector2.Distance(transform.position, player.position) <= attackRange;
    }

    public void AttackPlayer()
    {
        player.GetComponent<IDamageable>()?.TakeDamage(1);
    }

    public void TakeDamage(int amount)
    {
        health -= amount;
        if (health <= 0)
        {
            GameManager.Instance.AddScore(10);
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        PlayerHealth player = collision.collider.GetComponent<PlayerHealth>();
        if (player != null)
        {
            player.TakeDamage(player.currentHealth); // Instant death
        }
    }

}
