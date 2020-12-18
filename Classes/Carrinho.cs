

using System;
using System.Collections.Generic;

namespace POO_Interface.Classes
{
    public class Carrinho : Icarrinho
    {

        
        List<Produto> carrinho = new List<Produto>();

        public void Alterar(int _codigo, Produto produto)
        {
            carrinho.Find(x => x.Codigo == _codigo).Nome = produto.Nome;
            carrinho.Find(x => x.Codigo == _codigo).Preco = produto.Preco;
        }

        public void Cadastrar(Produto produto)
        {
            carrinho.Add(produto);
        }

        public void Deletar(Produto produto)
        {
            carrinho.Remove(produto);
        }

        public void Listar()
        {
            foreach(Produto itemCarrinho in carrinho){
                Console.WriteLine($"Produto : {itemCarrinho.Nome}");
                Console.WriteLine($"Preço: R$ {itemCarrinho.Preco} ");
                Console.WriteLine($"Código: {itemCarrinho.Codigo}");
            }
        }
    }
}