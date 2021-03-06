using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ProjectX.Models.Mapping
{
    public class PostSetMap : EntityTypeConfiguration<PostSet>
    {
        public PostSetMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Descricao)
                .IsRequired();


            // Table & Column Mappings
            this.ToTable("PostSet");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Descricao).HasColumnName("Descricao");
            this.Property(t => t.Quantidade).HasColumnName("Quantidade");
            this.Property(t => t.Beleza).HasColumnName("Beleza");
            this.Property(t => t.Data).HasColumnName("Data");
            this.Property(t => t.Votos).HasColumnName("Votos");
            this.Property(t => t.Local_Id).HasColumnName("Local_Id");
            this.Property(t => t.User_id).HasColumnName("User_Id");

            this.Property(t => t.IsAnonimo).HasColumnName("IsAnonimo");
            this.Property(t => t.Foto).HasColumnName("Foto");


            // Relationships
            this.HasRequired(t => t.LocalSet)
                .WithMany(t => t.PostSets)
                .HasForeignKey(d => d.Local_Id);
            this.HasRequired(t => t.UserSet).WithMany().HasForeignKey(t => t.User_id);

        }
    }
}
