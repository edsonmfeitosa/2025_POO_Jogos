using UnityEngine;

public class Aula03 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Magia fogo = new Magia("bola de fogo", 50, 
            "explosão em área");

        Magia gelo = new Magia();
        gelo.setNome("raio de gelo");
        gelo.setPoder(40);
        gelo.setDescricao("congela o inimigo");
        Debug.Log(fogo.lancarMagia());
        Debug.Log(gelo.lancarMagia("troll"));

        Debug.Log("Total de magias criadas: " + 
            Magia.getContarMagias());
        //float tempo = Time.deltaTime;
        //Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
