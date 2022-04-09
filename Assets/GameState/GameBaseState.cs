using UnityEngine;

public abstract class GameBaseState
{
    public abstract void EnterState(GameStateManager manager);
    public abstract void UpdateState(GameStateManager manager);
    public abstract void OnCollisionEnter(GameStateManager manager, Collision2D collision);
}
