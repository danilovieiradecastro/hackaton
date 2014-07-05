using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ProjectX.Models.Mapping
{
    public class LocalSetMap : EntityTypeConfiguration<LocalSet>
    {
        public LocalSetMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.GoogleID)
                .IsRequired();

            this.Property(t => t.GooglePlaceID)
                .IsRequired();

            this.Property(t => t.GoogleReference)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("LocalSet");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Nome).HasColumnName("Nome");
            this.Property(t => t.Descricao).HasColumnName("Descricao");
            this.Property(t => t.Tipo).HasColumnName("Tipo");
            this.Property(t => t.GoogleID).HasColumnName("GoogleID");
            this.Property(t => t.GooglePlaceID).HasColumnName("GooglePlaceID");
            this.Property(t => t.GoogleReference).HasColumnName("GoogleReference");
            this.Property(t => t.Latitude).HasColumnName("Latitude");
            this.Property(t => t.Longitude).HasColumnName("Longitude");
        }
    }
}
