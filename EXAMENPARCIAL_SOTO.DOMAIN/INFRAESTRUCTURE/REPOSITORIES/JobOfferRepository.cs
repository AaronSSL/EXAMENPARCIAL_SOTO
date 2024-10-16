using EXAMENPARCIAL_SOTO.DOMAIN.CORE.ENTITIES;
using EXAMENPARCIAL_SOTO.DOMAIN.CORE.INTERFACES;
using EXAMENPARCIAL_SOTO.DOMAIN.INFRAESTRUCTURE.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMENPARCIAL_SOTO.DOMAIN.INFRAESTRUCTURE.REPOSITORIES
{
    public class JobOfferRepository : IJobOfferRepository
    {
        private readonly Parcial20240222101508Context _dbContext;

        public JobOfferRepository(Parcial20240222101508Context dbContext)
        {
            _dbContext = dbContext;
        }

        // Obtener todos los Ofertas de trabajo
        public async Task<IEnumerable<JobOffer>> GetAttendees()
        {
            var jobOff = await _dbContext.JobOffer.ToListAsync();
            return jobOff;
        }

        // Insertar un nuevo Ofertas de trabajo
        public async Task<int> Insert(JobOffer jfs)
        {
            await _dbContext.JobOffer.AddAsync(jfs);
            int rows = await _dbContext.SaveChangesAsync();

            return rows > 0 ? jfs.Id : -1;
        }

        //actualizar Ofertas de trabajo
        public async Task<bool> Update(JobOffer jOFFER)
        {
            _dbContext.JobOffer.Update(jOFFER);
            int rows = await _dbContext.SaveChangesAsync();
            return rows > 0;
        }


        // Eliminar un Ofertas de trabajo
        public async Task<bool> Delete(int id)
        {
            var jobOff = await _dbContext.JobOffer.FirstOrDefaultAsync(c => c.Id == id);

            if (jobOff == null) return false;

            _dbContext.JobOffer.Remove(jobOff);
            int rows = await _dbContext.SaveChangesAsync();

            return (rows > 0);
        }
    }
}
