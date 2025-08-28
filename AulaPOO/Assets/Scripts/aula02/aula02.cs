using UnityEngine;

public class aula02 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Personagem pers = new Personagem("Maria", 100);
        pers.SetTipoPersonagem(TipoPersonagem.Guerreiro);
        Debug.Log("tipo: "+ pers.GetTipoPersonagem());
        pers.SetNome("Edson");
        pers.SetVida(100);

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
