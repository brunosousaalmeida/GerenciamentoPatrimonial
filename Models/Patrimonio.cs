using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciamentoPatrimonial.Models
{
    public class Patrimonio
    {
        public string _nome { get; set; }
        public int MarcaId { get; private set; }
        public string Descricao { get; set; }
        public int NumeroTombo { get; }

        public Patrimonio(string nome, int marcaId, string descricao)
        {
            Nome = nome;
            MarcaId = marcaId;
            Descricao = descricao;
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
