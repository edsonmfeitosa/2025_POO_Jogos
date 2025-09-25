using UnityEngine;

public class Armadura
{
    private string nome;
    private int defesa;

    public Armadura(string nome, int defesa)
    {
        this.nome = nome;
        this.defesa = defesa;
    }
    public int getDefesa()
    {
        return defesa;
    }
}
