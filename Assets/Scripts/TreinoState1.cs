using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MudarState
{
    State StateAtual;

    public void TrocarState(State novoState)
    {
        StateAtual = novoState;
    }
}
public abstract class State
{
    protected string StateAtual;

    public abstract void Enter();

    public abstract void Execute();

    public abstract void Exit();
} 
public class Andando: State
{
    public andando(string NovoState)
    {
        StateAtual = NovoState;
    }
    public override void Enter()
    {
        Debug.Log("Entrando no estado: " + StateAtual);
    }
    public override void Execute()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

        }
    }
    public override void Exit()
    {
        Debug.Log("Saindo do estado: " + StateAtual);
    }
}
public class Parado: State
{
    public Parado(string NovoState)
    {
        StateAtual = NovoState;
    }
    public override void Enter()
    {
        Debug.Log("entrando no estado: " + StateAtual);
    }
    public override void Execute()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

        }
    }
    public override void Exit()
    {
        Debug.Log("Saindo do estado: " + StateAtual);
    }
}