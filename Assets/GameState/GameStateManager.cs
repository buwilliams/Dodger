using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStateManager : MonoBehaviour
{
    GameBaseState currentState;

    public TextMeshProUGUI text;
    public GameObject start;
    public GameObject finish;
    public GameObject player;

    public AudioSource audioSuccess;
    public AudioSource audioFailure;
    public AudioSource audioBackground;

    public LevelStartState levelStartState = new LevelStartState();
    public LevelFailState levelFailState = new LevelFailState();
    public LevelSuccessState levelSuccessState = new LevelSuccessState();

    // Start is called before the first frame update
    void Start()
    {
        currentState = levelStartState;
        currentState.EnterState(this);
    }

    // Update is called once per frame
    void Update()
    {
        currentState.UpdateState(this);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        currentState.OnCollisionEnter(this, collision);
    }

    public void SwitchState(GameBaseState state)
    {
        currentState = state;
        currentState.EnterState(this);
    }

    public void LoadScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }

    public void PlayWaitLoad(string scene, AudioSource source)
    {
        StartCoroutine(PlaySoundThenLoadScene(scene, source));
    }
    IEnumerator Waiter(int seconds)
    {
        //Wait for 2 seconds
        yield return new WaitForSeconds(seconds);
    }

    IEnumerator PlaySoundThenLoadScene(string scene, AudioSource source)
    {
        source.Play();
        yield return new WaitWhile(() => source.isPlaying);
        LoadScene(scene);
    }
}
