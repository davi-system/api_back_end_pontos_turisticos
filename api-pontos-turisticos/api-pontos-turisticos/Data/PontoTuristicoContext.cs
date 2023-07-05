using Microsoft.EntityFrameworkCore;
using api_pontos_turisticos.Models;

namespace api_pontos_turisticos.Data
{
    public class PontoTuristicoContext : DbContext
    {
        public PontoTuristicoContext(DbContextOptions<PontoTuristicoContext> options) : base(options) { }

        public DbSet<PontoTuristico> PontoTuristico { get; set; }
    }
}
