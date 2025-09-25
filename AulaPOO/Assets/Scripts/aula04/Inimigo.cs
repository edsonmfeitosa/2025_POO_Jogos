using UnityEngine;

public class Inimigo
{
    private string nome;
    private int vida;
    private int dano;

    public Inimigo(string nome, int vida, int dano)
    {
        this.nome = nome;
        this.vida = vida;
        this.dano = dano;
    }
    public void Atacar(Player player)
    {
        player.ReceberDano(dano);
        Debug.Log($"{nome} atacou {player.getNome()}, " +
            $"causando {dano} de dano!");
    }
    public void ReceberDano(int dano)
    {
        vida -= dano;
        Debug.Log($"{nome} recebeu {dano} de dano. " +
            $"Vida restante: {vida}");
        if (vida <= 0)
        {
            Debug.Log($"{nome} foi derrotado!");
        }
    }
    public string getNome()
    {
        return nome;
    }
}
