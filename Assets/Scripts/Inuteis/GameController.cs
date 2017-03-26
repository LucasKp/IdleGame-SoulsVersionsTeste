using UnityEngine;
using System.Collections;

public enum GAME_STATE
{
    Start,
    Ingame,
    Shop,
    Load,
    Pause
}

public class GameController : MonoBehaviour
{
    public GAME_STATE currentState;
    private GAME_STATE nextState;

    void Start()
    {
        currentState = nextState;        
    }

    void Update()
    {
        switch (currentState)
        {
            case GAME_STATE.Start:
                {
                    ChangeState(GAME_STATE.Ingame);
                    break;
                }
            case GAME_STATE.Ingame:
                {
                    if (Input.GetKeyDown(KeyCode.A))
                    {
                        ChangeState(GAME_STATE.Pause);
                    }
                    break;
                }
            case GAME_STATE.Pause:
                {
                    Time.timeScale = 0;

                    if (Input.GetKeyDown(KeyCode.A))
                    {
                        Time.timeScale = 1;
                        ChangeState(GAME_STATE.Ingame);
                    }

                    break;
                }
            case GAME_STATE.Shop:
                {
                    break;
                }
        }
    }

    public void ChangeState(GAME_STATE newState)
    {
        nextState = newState;
    }
}
