using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Source
{
    public class Tecnologia : Produto
    {

        // Variavel privada que armazena a assinatura que acompanha o produto.
        private string _assinatura;

        // Construtor com parametros do produto de tecnologia.
        public Tecnologia(string nome, float preco, float peso, string fabricante, TipoProduto tipoProduto = TipoProduto.TECNOLOGIA, string assinatura = null)
        {
            Nome = nome;
            Preco = preco;
            Peso = peso;
            Fabricante = fabricante;
            _assinatura = assinatura;

            // Verifique se o tipo de produto é válido (Tecnologia).
            if (TipoProduto != TipoProduto.TECNOLOGIA)
            {
                // Redefine o tipo do produto para tecnologia.
                tipoProduto = TipoProduto.TECNOLOGIA;
            }

            // Se a assinatura for nula, entao retorne uma exception pro usuario.
            if (_assinatura == null)
            {
                throw new Exception("Assinatura não pode ser nula, defina um valor para assinatura e tente novamente!");
            }
            
            TipoProduto = tipoProduto;
        }

        public override void DescreverProduto()
        {
            base.DescreverProduto();
            Console.WriteLine($"Assinatura que acompanha o produto: {_assinatura}");
            Console.WriteLine("---------------------------------");
        }

    }
}
