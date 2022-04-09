using System.Collections;
using UnityEngine;

public class LevelFailState : GameBaseState
{
    public override void EnterState(GameStateManager manager)
    {
        Debug.Log("LeveFailState:EnterState");
        manager.audioBackground.Stop();
        //manager.audioFailure.Play();
        manager.PlayWaitLoad("SampleScene", manager.audioFailure);
    }

    public override void UpdateState(GameStateManager manager)
    {
        Debug.Log("LeveFailState:UpdateState");
    }

    public override void OnCollisionEnter(GameStateManager manager, Collision2D collision)
    {
        Debug.Log("LeveFailState:OnCollisonEnter");
    }
}
