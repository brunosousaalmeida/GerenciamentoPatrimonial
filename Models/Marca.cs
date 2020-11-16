using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciamentoPatrimonial.Models
{
    public class Marca
    {
        public string _nome;
        public int Id { get;}

        public Marca(string nome)
        {
            Nome = nome;
        }
        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

    }
}
