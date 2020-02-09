using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*public abstract class TreinoState1 
{
    protected string nomeState;

    public virtual void Execute()
    {

    }
}
public class statePlaying : TreinoState1 //sem singleton tanto a classe statePlaying quanto a classe statePaused teriam void start() e void awake()?
{
    public TreinoStateMachine1 treinoStaMa = new TreinoStateMachine1();
    public statePaused treinoStaPa = new statePaused("Paused");
    public statePlaying(string name)
    {
        nomeState = name;
    }
    public override void Execute()
    {
        Debug.Log(nomeState);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            treinoStaMa.modificarState(treinoStaPa);//argumento errado?
        }
    }
    void start()
    {
        treinoStaMa.modificarState(treinoStaPa);//argumento errado?
    }
    void Update()
    {
        treinoStaMa.executar();
    }
}
public class statePaused : TreinoState1
{
    public TreinoStateMachine1 treinoStaMa = new TreinoStateMachine1();
    public statePlaying treinoStaPl = new statePlaying("Playing");
    public statePaused(string name)
    {
        nomeState = name;
    }
    public override void Execute()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            treinoStaMa.modificarState(treinoStaPl);
        }
    }
    void start()
    {
        treinoStaMa.modificarState(statePlaying);
        
    }
    void Update()
    {
        treinoStaMa.executar();
    }
}*/
