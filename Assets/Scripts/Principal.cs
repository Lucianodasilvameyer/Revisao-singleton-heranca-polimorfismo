using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Principal : MonoBehaviour
{
    public static Principal singleton;
    public StatePlayer StatePl = new StatePlayer();
    public Morto Mort = new Morto("morto");
    public Vivo viv = new Vivo("Vivo");

    private void Awake()
    {
        if (singleton != this && singleton != null)
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
        StatePl.MudarState(Mort);
        StatePl.MudarState(viv);
    }
    private void Update()
    {
        StatePl.Executar();
        StatePl.Executar();
    }


}
public class StatePlayer
{
    public StateMortoOuVivo stateAtual;
    // Start is called before the first frame update

    public void MudarState(StateMortoOuVivo novoState)
    {
        stateAtual = novoState;
    }
    public void Executar()
    {
        stateAtual.Executar();
    }
}

public abstract class StateMortoOuVivo
{
    
    public string Nome;
    public virtual void Executar()
    {

    }
}
public class Morto : StateMortoOuVivo
{
    public Morto(string novoNome)
    {
        Nome = novoNome;
    }
    public override void Executar()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            Debug.Log("Morreu");
            Principal.singleton.StatePl.MudarState(Principal.singleton.viv);


        }

    }
}

public class Vivo: StateMortoOuVivo
{
    public Vivo(string novoNome)
    {
        Nome = novoNome;
    }
    public override void Executar()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            Debug.Log("Viveu");
            Principal.singleton.StatePl.MudarState(Principal.singleton.Mort);
        }
    }


}
 

