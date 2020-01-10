using EF.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EF
{
    internal class GenderConfiguration : EntityTypeConfiguration<Gender>
    {
        public GenderConfiguration()
        {
            ToTable("Gender");
            HasKey(u => u.GenderId);
            Property(u => u.GenderId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(u => u.Name).HasMaxLength(50).IsRequired();
        }
    }
}