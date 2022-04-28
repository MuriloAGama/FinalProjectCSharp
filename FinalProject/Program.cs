using System;
using System.Collections.Generic;
using FinalProject.Source;

namespace FinalProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            CadastrarProdutos();
        }

        /// <summary>
        /// Cadastra os produtos e imprime na tela suas descricoes.
        /// </summary>
        private static void CadastrarProdutos()
        {
            // Cria os produtos de tecnologia.
            Tecnologia monitor = new Tecnologia("Monitor", 2000.0f, 5.0f, "Asus", TipoProduto.TECNOLOGIA, "Garantia Estendida 12 Meses");
            Tecnologia iphone15 = new Tecnologia("Iphone15", 9999999.0f, 2.0f, "Apple", TipoProduto.TECNOLOGIA, "Seguro pro aparelho");

            // Cria os produtos de limpeza.
            Limpeza fralda = new Limpeza("Fralda", 100.0f, 1.0f, "Harpa", TipoProduto.LIMPEZA);
            Limpeza sabaoEmPo = new Limpeza("Sabão em pó", 50.0f, 1.0f, "Omo", TipoProduto.LIMPEZA);

            // Cria os produtos de alimento.
            Alimento pao = new Alimento("Pão", 10.0f, 1.0f, "Pão de queijo", TipoProduto.ALIMENTO, "12/2022");
            Alimento chocolate = new Alimento("Chocolate", 5.0f, 0.5f, "Nestle", TipoProduto.ALIMENTO, "12/2022");

            // Cria a lista.
            List<Produto> produtosList = new List<Produto>();
            
            // Adicionar os produtos de tecnologia dentro da lista de produtos.
            produtosList.Add(monitor);
            produtosList.Add(iphone15);

            // Adicionar os produtos de limpeza dentro da lista de produtos.
            produtosList.Add(fralda);
            produtosList.Add(sabaoEmPo);

            // Adicionar os produtos de alimento dentro da lista de produtos.
            produtosList.Add(pao);
            produtosList.Add(chocolate);

            // Cria as listas para subcategorizar os produtos em suas devidas categorias.
            List<Tecnologia> tecnologiaList = new List<Tecnologia>();
            List<Limpeza> limpezaList = new List<Limpeza>();
            List<Alimento> alimentoList = new List<Alimento>();

            // Loopeia atravez de toda lista de produtos generica.
            foreach (Produto produto in produtosList)
            {
                // Verifique cada possivel caso de tipo do produto.
                switch (produto.TipoProduto)
                {
                    // Caso alimento, adicione para sua lista especifica.
                    case TipoProduto.ALIMENTO:
                        alimentoList.Add((Alimento) produto);
                        break;

                    // Caso limpeza, adicione para sua lista especifica.
                    case TipoProduto.LIMPEZA:
                        limpezaList.Add((Limpeza) produto);
                        break;

                    // Caso tecnologia, adicione para sua lista especifica.
                    case TipoProduto.TECNOLOGIA:
                        tecnologiaList.Add((Tecnologia) produto);
                        break;
                }
            }

            // Imprime na tela a lista de produtos categorizados como alimentos.
            Console.WriteLine("--- Lista de Produtos Alimentos Cadastrados: ---");
            foreach (Alimento alimento in alimentoList)
            {
                alimento.DescreverProduto();
            }

            // Imprime na tela a lista de produtos categorizados como limpeza.
            Console.WriteLine("--- Lista de Produtos Limpeza Cadastrados: ---");
            foreach (Limpeza limpeza in limpezaList)
            {
                limpeza.DescreverProduto();
            }

            // Imprime na tela a lista de produtos categorizados como tecnologia.
            Console.WriteLine("--- Lista de Produtos Tecnologia Cadastrados: ---");
            foreach (Tecnologia tecnologia in tecnologiaList)
            {
                tecnologia.DescreverProduto();
            }
        }

    }
}
