using UnityEngine;

public class AttackState : BaseState
{
    private float attackCooldown = 1f;
    private float timer;

    public AttackState(Enemy enemy) : base(enemy) { }

    public override void Execute()
    {
        timer += Time.deltaTime;

        if (timer >= attackCooldown)
        {
            enemy.AttackPlayer();
            timer = 0f;
        }

        if (!enemy.IsInAttackRange())
            enemy.ChangeState(new ChaseState(enemy));
    }
}
