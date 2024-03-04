using Microsoft.EntityFrameworkCore;
using RestAPI.Data;
using RestAPI.Entities;

namespace RestAPI.Repositories
{
    public class OffreRepository
    {
        private readonly DataContext datacontext;

        public OffreRepository(DataContext _datacontext)
        {
            datacontext = _datacontext;
        }

        public async Task<List<Offre>> GetAll()
        {
            return await datacontext.Offre.ToListAsync();
        }

        public async Task<Offre> GetById(int id)
        {
            return await datacontext.Offre.FindAsync(id);
        }

        public async Task<Offre> Saveoffre(Offre offre)
        {
            datacontext.Offre.Add(offre);
            await datacontext.SaveChangesAsync();
            return offre;
        }

        public async Task<bool> Deleteoffre(int id)
        {
            var offre = await datacontext.Offre.FindAsync(id);
            if (offre == null)
            {
                return false;
            }
            
            datacontext.Offre.Remove(offre);
            await datacontext.SaveChangesAsync();
            return true; 
        }

    }
}
