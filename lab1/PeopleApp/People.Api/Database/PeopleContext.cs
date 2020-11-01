using Microsoft.EntityFrameworkCore;
using People.Api.Domain;

namespace People.Api.Database
{
    public class PeopleContext : DbContext
    {
        public PeopleContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<People.Api.Domain.People> Peoples { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<People.Api.Domain.People>().Ignore(c => c.Fullname);
        }
    }
}