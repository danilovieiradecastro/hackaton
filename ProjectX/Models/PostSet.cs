using System;
using System.Collections.Generic;

namespace ProjectX.Models
{
    public partial class PostSet
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int Quantidade { get; set; }
        public int Beleza { get; set; }
        public System.DateTime Data { get; set; }
        public int Votos { get; set; }
        public int Local_Id { get; set; }
        public int User_id { get; set; }
        public bool IsAnonimo { get; set; }
        public virtual LocalSet LocalSet { get; set; }
        public virtual UserSet UserSet { get; set; }
        public virtual byte[] Foto { get; set; }
    }
}
