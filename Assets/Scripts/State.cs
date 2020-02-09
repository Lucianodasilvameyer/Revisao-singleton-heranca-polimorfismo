using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class State
{
    protected string stateName; //a variavel protected só é acessível dentro de sua classe, por instancias da mesma classe e por herança? 
    

    public virtual void Execute()//o metodo virtual é o q pode ser reescrito em outras classes?
    {
        Debug.Log(stateName);
    }
}

public class PlayingState : State
{
    public PlayingState(string name)
    {
        stateName = name;
    }

    public override void Execute()
    {
        Debug.Log(stateName);

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Main.singleton.stateMachine.ChangeState(Main.singleton.paused);//aqui o singleton esta pegando as instancias da classe main, tornando desnecesario cria-las aqui?
        }
    }
}

public class PausedState : State
{
    public PausedState(string name)
    {
        stateName = name;
    }

    public override void Execute()
    {
        Debug.Log(stateName);

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Main.singleton.stateMachine.ChangeState(Main.singleton.playing);
        }
    }
}
