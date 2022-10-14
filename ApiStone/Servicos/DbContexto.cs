using ApiStone.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiStone.Servicos
{
    public class DbContexto : DbContext
    {
        public DbContexto(DbContextOptions<DbContexto> options) : base(options) { }

        public DbContexto() { }

        public DbSet<Cliente> Clientes { get; set; }
    }
}
