using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10f;
    public int damage = 1;
    public float lifetime = 3f;

    private float timer;

    void OnEnable()
    {
        // Reset lifetime when reused from pool
        timer = 0f;
    }

    void Update()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime);

        timer += Time.deltaTime;
        if (timer >= lifetime)
        {
            gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Optional: ignore player
        if (other.GetComponent<PlayerHealth>() != null)
            return;

        IDamageable dmg = other.GetComponent<IDamageable>();
        if (dmg != null)
            dmg.TakeDamage(damage);

        gameObject.SetActive(false);
    }
}
