using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoovingState : State
{
    public override void OnEnterState()
    {
        print("J'entre dans l'état mooving");
    }

    public override void OnExitState()
    {
        print("je quitte mon état d'attaque");
    }

    public override void UpdateState()
    {
        //Se déplace et suis le joueur

        //if(playerinrange === true){
        GetComponent<StateManager>().SwitchState(GetComponent<StateManager>().attacking);

    }
}
