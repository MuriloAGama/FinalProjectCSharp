using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Source
{
    public enum TipoProduto { ALIMENTO, LIMPEZA, TECNOLOGIA }

    public abstract class Produto
    {

        // ** Propriedades
        public string Nome { get; set; }
        public float Preco { get; set; }
        public float Peso { get; set; }
        public string Fabricante { get; set; }
        public TipoProduto TipoProduto { get; set; }


        // Construtor vazio.
        public Produto() { }


        // Construtor com parâmetros.
        public Produto(string nome, float preco, float peso, string fabricante, TipoProduto tipoProduto)
        {
            Nome = nome;
            Preco = preco;
            Peso = peso;
            Fabricante = fabricante;
            TipoProduto = tipoProduto;
        }

        
        /// <summary>
        /// Metodo que descreve todas caracteristicas base do produto.
        /// </summary>
        public virtual void DescreverProduto()
        {
            Console.WriteLine($"Nome do produto: {Nome}");
            Console.WriteLine($"Valor do preco: {Preco}");
            Console.WriteLine($"Quantidade do peso: {Peso}");
            Console.WriteLine($"Nome do fabricante: {Fabricante}");
            Console.WriteLine($"Tipo do produto: {TipoProduto}");
        }

    }
}
