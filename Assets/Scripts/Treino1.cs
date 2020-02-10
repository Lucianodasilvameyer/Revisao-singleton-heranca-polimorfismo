using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Treino1: MonoBehaviour
{
    public static Treino1 singleton;
    MudarState mudarState = new MudarState();
    public Andando andando = new Andando("Andar");
    public Parado parado = new Parado("Parado");

    private void Awake()
    {
        if (singleton != this && singleton != null) 
        {
            GameObject.Destroy(this); //Destroi um singleton anterior direrente para que?
        }
        else
        {
            singleton = this;
        }
    }
    void Start()
    {
        mudarState.TrocarState(parado);
    }
    void AwaKe()
    {
        mudarState.Execute();
    }
}
public class MudarState
{
    public State StateAtual;
    public State StateAnterior;

    
    public void Execute()
    {
        StateAtual.Execute();
    }
    public void TrocarState(State NovoState)
    {
       if(StateAtual != null)
       {
            StateAtual.Exit();
            StateAnterior = StateAtual;
       }
       StateAtual = NovoState;
       StateAtual.Enter();    
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
    public andando(string NovoState)// o construtor serve para dizer com qual estado se esta lidando?
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
            Treino1.singleton.mudarState.TrocarState(Treino1.singleton.parado);
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
            Treino1.singleton.mudarState.trocarState(Treino1.singleton.andando);
        }
    }
    public override void Exit()
    {
        Debug.Log("Saindo do estado: " + StateAtual);
    }
}