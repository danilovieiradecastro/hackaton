using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectX.Models
{
    public class ViewModelPost
    {
        public List<PostSet> Posts { get; set; }
        public IEnumerable<LocalSet> ListaBaladas { get; set; }
        public PostSet post { get; set; }
        public LocalSet BaladaSelecionada;
        public bool isBaladaSelecionada { get; set; }

        public string Site { get; set; }
        public string Telefone { get; set; }

        public string Endereco { get; set; }

        public double Rating { get; set; }

        public string Name { get; set; }    
    }
}