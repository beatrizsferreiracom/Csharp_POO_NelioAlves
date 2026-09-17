using System;
using System.Globalization;
using System.Net.WebSockets;

namespace Properties
{
    internal class Produto
    {
        private string _nome;
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        public Produto()
        {
        }

        public Produto(string nome, double preco)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = 0;
        }

        public Produto(string nome, double preco, int quantidade)
        {
            Quantidade = quantidade;
        }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                    _nome = value;
            }
        }
        
        /*public double Preco {
            get { return _preco; }
        }

        public double Quantidade
        {
            get { return _quantidade; }
        } */
    }
}