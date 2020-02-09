using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExemploHeranca : MonoBehaviour
{
    ClasseA objetoA = new ClasseA();
    ClasseB objetoB = new ClasseB();

    private void Awake()
    {
        Debug.Log("Variavel id do objetoA: " + objetoA.id);
        Debug.Log("Variavel id do objetoB: " + objetoB.id);

        objetoB.id = 2;

        Debug.Log("Variavel id do objetoA: " + objetoA.id);
        Debug.Log("Variavel id do objetoB: " + objetoB.id);
    }
}

public class ClasseA
{
    public int id = 1;
}

public class ClasseB : ClasseA
{
    
}
