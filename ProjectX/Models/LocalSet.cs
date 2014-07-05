using System;
using System.Collections.Generic;

namespace ProjectX.Models
{
    public partial class LocalSet
    {
        public LocalSet()
        {
            this.PostSets = new List<PostSet>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public Nullable<int> Tipo { get; set; }
        public string GoogleID { get; set; }
        public string GooglePlaceID { get; set; }
        public string GoogleReference { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public virtual ICollection<PostSet> PostSets { get; set; }
    }
}
