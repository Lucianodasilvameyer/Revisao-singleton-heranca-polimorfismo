using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine
{
    private State currentState;

    //Função chamada no Update() da classe Main
    public void ExecuteState()
    {
        currentState.Execute();
    }

    //Função para trocar de estado
    public void ChangeState(State newState)
    {
        //Parar o estado atual

        //Colocar um novo estado
        currentState = newState;
    }
}
