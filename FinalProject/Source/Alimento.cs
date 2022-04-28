using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Source
{
    public class Alimento : Produto
    {
        // Variavel privada que armazena a data de validade do alimento.
        private string _validade;
        
        // Construtor com parametros do produto de alimento.
        public Alimento(string nome, float preco, float peso, string fabricante, TipoProduto tipoProduto = TipoProduto.ALIMENTO, string validade = null)
        {
            Nome = nome;
            Preco = preco;
            Peso = peso;
            Fabricante = fabricante;
            _validade = validade;

            // Verifique se o tipo de produto é válido (Alimento).
            if (tipoProduto != TipoProduto.ALIMENTO)
            {
                // Redefine o tipo do produto para alimento.
                tipoProduto = TipoProduto.ALIMENTO;
            }

            // Se a validade for nula, retorne uma exception (Não é possível criar um alimento sem validade).
            if (validade == null)
            {            
                throw new Exception("Não é possível criar um alimento sem validade");
            }

            TipoProduto = tipoProduto;
        }

        public override void DescreverProduto()
        {
            base.DescreverProduto();
            Console.WriteLine($"Validade do produto: {_validade}");
            Console.WriteLine("---------------------------------");
        }
    }
}
