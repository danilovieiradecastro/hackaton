using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace ProjectX.Models.Mapping
{
  public class UserSetMap: EntityTypeConfiguration<UserSet>
  {
    public UserSetMap()
    {
      // Primary Key
      this.HasKey(t => t.Id);

      // Properties

      this.ToTable("UserSet");
      this.Property(t => t.Id).HasColumnName("Id");
      this.Property(t => t.Email).HasColumnName("Email");
      this.Property(t => t.Nome).HasColumnName("Nome");
      this.Property(t => t.IdIdentity).HasColumnName("IdIdentity");
    }  
  }
}