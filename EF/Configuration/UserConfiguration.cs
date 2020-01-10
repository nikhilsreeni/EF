using EF.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EF
{
    internal class UserConfiguration : EntityTypeConfiguration<User>
    {
        public UserConfiguration()
        {
            ToTable("User");
            HasKey(u => u.UserId);
            Property(u => u.UserId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(u => u.Name).HasMaxLength(50).IsRequired();

            HasRequired(t => t.Gender).WithMany(c => c.User).HasForeignKey
            (t => t.GenderId).WillCascadeOnDelete(true);
        }
    }
}