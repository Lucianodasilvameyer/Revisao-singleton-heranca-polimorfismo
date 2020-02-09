using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreinoStateMachine1 : MonoBehaviour
{
    private State stateAtual;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void modificarState(State novoState)
    {
        stateAtual = novoState;

    }
    public void executar()
    {
        stateAtual.Execute();
    }
}
