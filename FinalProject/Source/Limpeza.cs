using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Source
{
    public class Limpeza : Produto
    {

        // Construtor com parametros do produto de limpeza
        public Limpeza(string nome, float preco, float peso, string fabricante, TipoProduto tipoProduto = TipoProduto.LIMPEZA)
        {
            Nome = nome;
            Preco = preco;
            Peso = peso;
            Fabricante = fabricante;

            // Verifique se o tipo de produto é válido (Tecnologia).
            if (tipoProduto != TipoProduto.LIMPEZA)
            {
                // Redefine o tipo do produto para tecnologia.
                tipoProduto = TipoProduto.LIMPEZA;    
            }

            TipoProduto = tipoProduto;
        }

        public override void DescreverProduto()
        {
            base.DescreverProduto();
            Console.WriteLine("---------------------------------");
        }

    }
}
