using UnityEngine;

public class ChaseState : BaseState
{
    public ChaseState(Enemy enemy) : base(enemy) { }

    public override void Execute()
    {
        enemy.MoveTowardsPlayer();

        if (enemy.IsInAttackRange())
            enemy.ChangeState(new AttackState(enemy));
    }
}
