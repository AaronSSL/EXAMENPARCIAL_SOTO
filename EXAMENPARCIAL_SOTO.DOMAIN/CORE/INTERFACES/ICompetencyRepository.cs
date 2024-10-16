using EXAMENPARCIAL_SOTO.DOMAIN.CORE.ENTITIES;

namespace EXAMENPARCIAL_SOTO.DOMAIN.CORE.INTERFACES
{
    public interface ICompetencyRepository
    {
        Task<bool> Delete(int id);
        Task<IEnumerable<Competency>> GetCompetency();
        Task<int> Insert(Competency attendee);
        Task<bool> Update(Competency cmpt);
    }
}