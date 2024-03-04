using Microsoft.EntityFrameworkCore;
using RestAPI.Entities;

namespace RestAPI.Data
{
    //DbContext est le principal point d'entrée pour les opérations de base CRUD
    public class DataContext : DbContext
    {
        //configurer le contexte de base de données (la chaîne de connexion...)
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
                
        }

        //définit l'entité du type Offre dans la base de données
        public DbSet<Offre> Offre { get; set; }
    }
}
