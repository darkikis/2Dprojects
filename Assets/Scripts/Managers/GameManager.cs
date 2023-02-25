using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameState currentstate;
    public GameEvent OnStartEvent;
    void Start()
    {
        currentstate = GameState.ON_START;
        EvaluateState();
    }

    public void EvaluateState()
    {
        switch (currentstate)
        {
            case GameState.ON_START:
                OnStartEvent.Raise();
                break;
        }
    }
 
}

public enum GameState
{
    LOADING,
    ON_START,
    PLAYING,
    GAME_OVER,
    PAUSE
}
