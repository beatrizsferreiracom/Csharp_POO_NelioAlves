using System;
using System.Globalization;

namespace Encapsulamento
{
    internal class Produto
    {
        private string _nome;
        private double _preco;
        private int _quantidade;

        public Produto()
        {
        }

        public Produto(string nome, double preco)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = 0;
        }

        public Produto(string nome, double preco, int quantidade)
        {
            _quantidade = quantidade;
        }

        public string GetNome()
        {
            return _nome;
        }

        public void SetNome(string nome)
        {
            if (nome != null && nome.Length > 1) 
                _nome = nome;
        }

        public double GetPreco()
        {
            return _preco;
        }

        public double GetQuantidade()
        {
            return _quantidade;
        }
    }
}