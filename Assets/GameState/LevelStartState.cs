using UnityEngine;

public class LevelStartState : GameBaseState
{
    private float progress = 0;
    private float start_y = 0;
    private float end_y = 0;
    private float one_percent = 0;

    public override void EnterState(GameStateManager manager)
    {
        Debug.Log("LevelStartState:EnterState");

        manager.text.text = "0% progress";

        start_y = manager.finish.transform.position.y;
        end_y = manager.start.transform.position.y;
        one_percent = (end_y - start_y) / 100;

        manager.audioBackground.Play();
    }

    public override void UpdateState(GameStateManager manager)
    {
        Debug.Log("LevelStartState:UpdateState");
        float pixel_moved = manager.player.transform.position.y - start_y;
        progress = 100 - Mathf.Round(pixel_moved / one_percent);
        manager.text.text = $"{progress}% progress";
    }

    public override void OnCollisionEnter(GameStateManager manager, Collision2D collision)
    {
        Debug.Log("LevelStartState:OnCollisonEnter");
        string tag = collision.gameObject.tag;

        Debug.Log($"Collision Detected {tag}");

        if (tag == "Spike")
            manager.SwitchState(manager.levelFailState);

        if (tag == "Level Complete")
            manager.SwitchState(manager.levelSuccessState);
    }
}
