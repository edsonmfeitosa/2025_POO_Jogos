using UnityEngine;

public class Escudo
{
    private string nome;
    private int defesaExtra;

    public Escudo(string nome, int defesaExtra)
    {
        this.nome = nome;
        this.defesaExtra = defesaExtra;
    }
    public int getDefesaExtra()
    {
        return defesaExtra;
    }
}
