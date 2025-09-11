using UnityEngine;

public class Magia
{
    private string nome;
    private int poder;
    private string descricao;
    private static int contarMagias = 0;

    public Magia(string nome, int poder, string descricao)
    {
        this.nome = nome;
        this.poder = poder;
        this.descricao = descricao;
        contarMagias++;
    }
    public Magia()
    {
        contarMagias++;
    }
    public static int getContarMagias()
    {
        return contarMagias;
    }
    public string getNome()
    {
        return nome;
    }
    public void setNome(string nome)
    {
        this.nome = nome;
    }
    public int getPoder()
    {
        return poder;
    }
    public void setPoder(int poder)
    {
        this.poder = poder;
    }
    public string getDescricao()
    {
        return descricao;
    }
    public void setDescricao(string descricao)
    {
        this.descricao = descricao;
    }
    public string lancarMagia()
    {
        return "Lançando magia: " + 
            nome + " com poder de " + 
            poder + ". Descrição: " + 
            descricao;
    }
    public string lancarMagia(string alvo)
    {
        return "Lançando magia: " + 
            nome + " com poder de " + 
            poder + " no alvo " + alvo + 
            ". Descrição: " + descricao;
    }
}
