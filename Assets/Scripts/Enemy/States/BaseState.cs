public abstract class BaseState
{
    protected Enemy enemy;

    public BaseState(Enemy enemy)
    {
        this.enemy = enemy;
    }

    public abstract void Execute();
}
