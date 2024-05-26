using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoArrayC_.Aula1_01;

 class Aula1_01
{
    public static void main()
    {
        // Aula 01

        Console.WriteLine("PROGRAMA DE MÉDIA DE IDADES:");

        int idade0 = 30;
        int idade1 = 40;
        int idade2 = 17;
        int idade3 = 21;
        int idade4 = 18;

        int media = (idade0 + idade1 + idade2 + idade3 + idade4) / 5;
        Console.WriteLine("A média das idades são : " + media);

        //produz muitas linhas de código, dificulta modularização, dificulta a nomeção de variaveis etc..

        int[] idades = {30,40,17,21,18 };


        media = (idades[0] + idades[1] + idades[2] + idades[3] + idades[4]) / 5;

        Console.WriteLine("A média das idades são : " + media);

        //produz o mesmo código com apenas uma variavel (idades)

        testaArrayInt(idades);

    }
    public static void testaArrayInt(int[] myArray)
    {
        int media;
        int acumulador = 0;
        //<array>.lenght traz o tamanho do array
        Console.WriteLine($"Tamanho do Array {myArray.Length}");

        // usamos array.lenght para percormos um array  
        for (int i = 0; i < myArray.Length; i++)
        {
            int idade = myArray[i];
            //<array>[i] pega a idade na posição atual do loop
            Console.WriteLine($"Índice [{i}] = {myArray[i]}");
            acumulador += myArray[i];
        }
        media = acumulador / myArray.Length;
        Console.WriteLine("A média das idades são : " + media);
    }

    /*Esther está iniciando na posição de pessoa desenvolvedora estagiária e precisa 
     * declarar um array de strings para armazenar os dias da semana e que possua um
     * tamanho suficiente. E ela precisa iniciar todas as posições do array na sequência, 
     * com os respectivos dias da semana.
     * Selecione a alternativa que melhor representa a melhor escolha para Esther.
     * 
     * string [] _diasDaSemana= new string[7];
          _diasDaSemana[0]=”segunda”;
          _diasDaSemana[1]=”terça”;
          _diasDaSemana[2]=”quarta”;
          _diasDaSemana[3]=”quinta”;
          _diasDaSemana[4]=”sexta”;
          _diasDaSemana[5]=”sábado”;
          _diasDaSemana[6]=”domingo”;
    */


    /*
     *  
    Para saber mais: outras formas de inicialização de um Array

    Como vimos, os arrays, ou vetores, são um agrupamento de elementos que 
    armazenamos em uma sequência, sendo o primeiro elemento do array o 
    índice zero. Normalmente, quando criamos uma estrutura deste tipo, temos 
    que definir sua dimensão, que pode ser única ou multidimensional. Vamos a 
    um exemplo de um array de uma dimensão:

    int[] numeros = new int[10]; 
    Podemos ter ainda um array com mais de uma dimensão, como por exemplo:

    int[,] numeros = new int[3,3];
    Depois de entender como criar arrays, é importante entender que eles são 
    tipos por referência, daí a palavra reservada new na sua declaração. Mas afinal, 
    quais as formas que temos para iniciar esse tipo de estrutura? Primeiramente temos que 
    lembrar que para manipular os arrays, vamos utilizar seus índices, e que todo array em 
    C# inicia no 0.

    Na forma mais básica de se declarar e inicializar um array 
    temos:string[] palavras = new string[10] e para inserir valores 
    recorremos à: palavras[0]="André.". Neste exemplo primeiro é declarado o array e 
    depois inserimos os elementos em cada índice. Mas também podemos declará-lo e 
    iniciá-lo por exemplo:

    string [] palavras= new string[5] {"André","Jose","Andressa","Neia","Sarah"}`.
    Podemos também omitir o número de elementos como no exemplo:

      double[] valores={2.6,9.7,7.5,1.8};
    Estas são algumas das formas que temos para definir um array usando o C#. 
    Para saber ainda mais vamos deixar aqui o link da documentação oficial da 
    Microsoft Matrizes Guia de Programação em C#.
     */

}
