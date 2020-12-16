using System;
using System.Collections.Generic;

namespace Lista_de_Objetos
{
    class Program
    {
        static void Main(string[] args)
        {   
            //Criar lista
            List<Produto> produtos = new List<Produto>();

            //Adicionamos produtos atraves de instancias com construtores
            produtos.Add(new Produto(1, "café pequeno", 2f));
            produtos.Add(new Produto(2, "café médio", 3f));
            produtos.Add(new Produto(3, "café grande", 4f));
            produtos.Add(new Produto(4, "pão com manteiga", 2.5f));
            produtos.Add(new Produto(5, "pão na chapa", 3.5f));

            //Ou atraves de instancias basicas e suas atribuições
            Produto coxinha = new Produto();
            coxinha.Codigo = 6;
            coxinha.Nome = "coxinha";
            coxinha.Preco = 3f;

            produtos.Add(coxinha);

            //Podemos mostrar os itens da lista com foreach
            foreach (Produto item in produtos)
            {
                Console.WriteLine($"Codigo - {item.Codigo}, Nome - {item.Nome}, Preço - {item.Preco}");
            }

            //Podemos tirar itens da lista atraves de seu indice de array:
            //Linha 3 removida, posição de array 2 cafe grande
            produtos.RemoveAt(2);

            //Tambem podemos remover um produto usando a expressao de lambda e o metodo RemoveAll
            //Linha 5 removida, posição de array 4 pão com manteiga
            produtos.RemoveAll(x => x.Nome == "pão com manteiga");

            Console.WriteLine("\nLista alterada: ");

            //Checamos para ver se foi removido
            foreach (Produto item in produtos)
            {
                Console.WriteLine($"Codigo - {item.Codigo}, Nome - {item.Nome}, Preço - {item.Preco}");
            } 


        }//main
    }
}
