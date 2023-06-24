using Microsoft.EntityFrameworkCore;
using WebApplicationProjeto.Model;

namespace WebApplicationProjeto.Infraestrutura
{
    public class ConnectionContext: DbContext
    {
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Post> Post{ get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
          => optionsBuilder.UseNpgsql(
              "Server=localhost;" +
              "Port=5432;Database=banco1;" +
              "User Id=postgres;" +
              "Password=123;");
    }
}
