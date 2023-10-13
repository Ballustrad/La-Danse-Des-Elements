using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateManager : MonoBehaviour
{

    public State currentState;

    public State mooving;
    public State attacking;

    void Start()
    {
        currentState.OnEnterState();
    }

    void Update()
    {
        currentState.UpdateState();
    }

    public void SwitchState(State NewState)
    {
        currentState.OnExitState();

        currentState = NewState;

        currentState.OnEnterState();
    }
}
