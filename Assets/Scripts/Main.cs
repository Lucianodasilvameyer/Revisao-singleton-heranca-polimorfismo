using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    public static Main singleton;

    public StateMachine stateMachine = new StateMachine();

    public PlayingState playing = new PlayingState("Playing");//aqui na instancia com o construtor, o metodo Execute esta incluido? 
    public PausedState paused = new PausedState("Paused");//aqui na instancia com o construtor, o metodo Execute esta incluido?

    void Awake()
    {
        if(singleton != this && singleton != null) // se o singleton necessario for dirente deste e se tiver algum tem q ser destruido?
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
        stateMachine.ChangeState(playing);//desnecesario playing.execute?
                                          //a ideia aqui 
    }    

    void Update()
    {
        stateMachine.ExecuteState();
    }
}
