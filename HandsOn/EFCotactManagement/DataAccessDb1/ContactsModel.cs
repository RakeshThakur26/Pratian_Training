using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace EFCotactManagement.DataAccessDb1
{
    public partial class ContactsModel : DbContext
    {
        public ContactsModel()
            : base("name=ContactsModel")
        {
        }

        public virtual DbSet<Contact> Contacts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>()
                .Property(e => e.FirstName)
                .IsFixedLength();

            modelBuilder.Entity<Contact>()
                .Property(e => e.MiddleName)
                .IsFixedLength();

            modelBuilder.Entity<Contact>()
                .Property(e => e.LastName)
                .IsFixedLength();

            modelBuilder.Entity<Contact>()
                .Property(e => e.Gender)
                .IsFixedLength();

            modelBuilder.Entity<Contact>()
                .Property(e => e.Location)
                .IsFixedLength();

            modelBuilder.Entity<Contact>()
                .Property(e => e.Mobile)
                .IsFixedLength();

            modelBuilder.Entity<Contact>()
                .Property(e => e.Email)
                .IsFixedLength();
        }
    }
}
