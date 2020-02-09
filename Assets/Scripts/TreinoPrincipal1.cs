using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreinoPrincipal1 : MonoBehaviour
{
    public static TreinoPrincipal1 singleton;
    public StateJogador stateJogador = new StateJogador();
    public StateMorto stateMorto = new StateMorto("Morto");
    public StateVivo stateVivo = new StateVivo("Vivo");

    private void Awake()
    {
        if(singleton != this && singleton != null)
        {
            GameObject.Destroy(this);
        }
        else
        {
            singleton = this;
        }
    }
    private void Start()
    {
        stateJogador.trocarState(stateMorto);
        stateJogador.trocarState(stateVivo);
    }
    private void Update()
    {
        stateJogador.Execute();
        stateJogador.Execute();
    }
}    
public class StateJogador
{
    public MortoOuVivoState StateAtual;

    public void trocarState(MortoOuVivoState NovoState)
    {
        StateAtual = NovoState;
    }
    public void Execute()
    {
        StateAtual.Execute();
    }
}   
public abstract class MortoOuVivoState 
{
    protected string nome;

    public virtual void Execute() 
    {

    }
}
public class StateMorto: MortoOuVivoState
{
    public StateMorto(string stateAtual)
    {
        nome = stateAtual;
    }
    public override void Execute()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            Debug.Log("Morto");
            TreinoPrincipal1.singleton.stateJogador.trocarState(TreinoPrincipal1.singleton.stateMorto);
        }
    }
}
public class StateVivo: MortoOuVivoState
{
    public StateVivo(string stateAtual)
    {
        nome = stateAtual;
    }
    public override void Execute()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            Debug.Log("Vivo");
            TreinoPrincipal1.singleton.stateJogador.trocarState(TreinoPrincipal1.singleton.stateVivo);
        }
    }
}


