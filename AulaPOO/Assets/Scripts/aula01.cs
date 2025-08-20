using Assets;
using UnityEngine;

public class aula01 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Pessoa p1 = new Pessoa();
        p1.receberUmNome("Adam");

        Pessoa p2 = new Pessoa();
        p2.receberUmNome("Edson");

        Debug.Log(p2.perguntarONome(p1));



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
