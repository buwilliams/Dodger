using UnityEngine;

public class LevelSuccessState : GameBaseState
{
    public override void EnterState(GameStateManager manager)
    {
        Debug.Log("LevelSuccessState:EnterState");
        manager.audioBackground.Stop();
        manager.audioSuccess.Play();

        manager.text.text = "Level complete!";
    }

    public override void UpdateState(GameStateManager manager)
    {
        Debug.Log("LevelSuccessState:UpdateState");
    }

    public override void OnCollisionEnter(GameStateManager manager, Collision2D collision)
    {
        Debug.Log("LevelSuccessState:OnCollisonEnter");
    }

}
