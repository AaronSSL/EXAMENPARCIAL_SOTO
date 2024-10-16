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
    public class CompetencyRepository : ICompetencyRepository
    {
        private readonly Parcial20240222101508Context _dbContext;

        public CompetencyRepository(Parcial20240222101508Context dbContext)
        {
            _dbContext = dbContext;
        }

        // Obtener todos los COMPETENCY
        public async Task<IEnumerable<Competency>> GetCompetency()
        {
            var comp = await _dbContext.Competency.ToListAsync();
            return comp;
        }

        // Insertar un nuevo COMPETENCY
        public async Task<int> Insert(Competency attendee)
        {
            await _dbContext.Competency.AddAsync(attendee);
            int rows = await _dbContext.SaveChangesAsync();

            return rows > 0 ? attendee.Id : -1;
        }

        //ACTUALIZAR COMPETENCY
        public async Task<bool> Update(Competency cmpt)
        {
            _dbContext.Competency.Update(cmpt);
            int rows = await _dbContext.SaveChangesAsync();
            return rows > 0;
        }


        // Eliminar COMPETENCY
        public async Task<bool> Delete(int id)
        {
            var attendee = await _dbContext.Competency.FirstOrDefaultAsync(c => c.Id == id);

            if (attendee == null) return false;

            _dbContext.Competency.Remove(attendee);
            int rows = await _dbContext.SaveChangesAsync();

            return (rows > 0);
        }
    }
}
