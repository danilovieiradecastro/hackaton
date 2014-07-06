using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectX.Models
{
    public class ViewModelPostDetail
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string ClassificationImg { get; set; }
        public System.DateTime Data { get; set; }
        public string UserName { get; set; }
        public bool IsAnonimo { get; set; }
        public virtual byte[] Foto { get; set; }
    }

    public class ViewModelPost
    {
        public List<ViewModelPostDetail> Posts { get; set; }
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