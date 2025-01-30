using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using WorldCups.Models;
namespace WorldCups.Data
{
    public class ApplicationDibContext: DbContext

    {
        public ApplicationDibContext(DbContextOptions<ApplicationDibContext> Option):base(Option)
        {

        }
        public DbSet<Categries> Categries { get; set; }
        public DbSet<CatogorisTransportation> CatogorisTransportation { get; set; }
        public DbSet<studium1> studium1 { get; set; }
        public DbSet<Hotel> Hotel { get; set; }
        public  DbSet<TableFootbul> TableFootbul { get; set; }
        public DbSet<Transport> Transport { get; set; }



    }
}
