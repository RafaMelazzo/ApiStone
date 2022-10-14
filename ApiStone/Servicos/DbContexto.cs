using Microsoft.EntityFrameworkCore;

namespace ApiStone.Servicos
{
    public class DbContexto : DbContext
    {
        public DbContexto(DbContextOptions<DbContexto> options) : base(options) { }

        public DbContexto() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string conexao = "Server=localhost;Port=3306;Database=myDataBase;Uid=gama;Pwd=academy;";

        }
    }
}
