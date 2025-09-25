using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class aula04 : MonoBehaviour
{
    
    void Start()
    {
        //exemploArrayLista();

        //aula de associação de objetos
        Player player = new Player("Herói", 100);
        Inimigo inimigo = new Inimigo("Goblin", 50, 15);
        Arma espada = new Arma("Espada longa", 20);
        Armadura armadura = new Armadura("Armadura de couro", 5);
        Escudo escudo = new Escudo("Escudo de madeira", 3);
        player.setArma(espada);
        player.setArmadura(armadura);
        player.setEscudo(escudo);
        player.Atacar(inimigo, espada);
        inimigo.Atacar(player);
        player.Atacar(inimigo, espada);
        inimigo.Atacar(player);
        Arma arco = new Arma("Arco e flecha", 15);
        player.setArma(arco);



    }
    void exemploArrayLista()
    {
        //Array e Lista
        //Array
        int[] numeros = new int[3];
        numeros[0] = 10;
        numeros[1] = 20;
        numeros[2] = 30;
        Debug.Log("Primeira posição do array: " + numeros[0]);
        for (int i = 0; i < numeros.Length; i++)
        {
            Debug.Log("Posição " + (i + 1) + " do array: " + numeros[i]);
        }
        foreach (int numero in numeros)
        {
            Debug.Log("Número do array: " + numero);
        }
        //Lista
        List<string> frutas = new List<string>();
        frutas.Add("Maçã");
        frutas.Add("Banana");
        frutas.Add("Laranja");
        Debug.Log("Primeira fruta da lista: " + frutas[0]);
        frutas.Remove("Banana");
        Debug.Log("Quantidade de frutas: " + frutas.Count);
        for (int i = 0; i < frutas.Count; i++)
        {
            Debug.Log("Fruta " + (i + 1) + " da lista: " + frutas[i]);
        }
        foreach (string fruta in frutas)
        {
            Debug.Log("Fruta da lista: " + fruta);
        }
    }


}
