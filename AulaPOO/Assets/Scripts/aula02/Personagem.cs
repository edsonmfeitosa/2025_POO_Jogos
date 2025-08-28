using UnityEngine;

public enum TipoPersonagem
{
    Guerreiro,
    Mago,
    Arqueiro
}
public class Personagem
{
    private TipoPersonagem tipo;
    private string nome;
    private int vida;

    public Personagem(string nome, int vida)
    {
        this.nome = nome;
        this.vida = vida;
    }

    public TipoPersonagem GetTipoPersonagem() 
    { 
        return tipo; 
    }
    public void SetTipoPersonagem(TipoPersonagem tipo)
    {
        this.tipo = tipo;
    }
    public string GetNome()
    {
        return nome;
    }
    public void SetNome(string nome)
    {
        this.nome = nome;
    }
    public int GetVida()
    {
        return vida;
    }
    public void SetVida(int vida)
    {
        this.vida = vida;
    }
}
