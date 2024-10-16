using EXAMENPARCIAL_SOTO.DOMAIN.CORE.ENTITIES;

namespace EXAMENPARCIAL_SOTO.DOMAIN.CORE.INTERFACES
{
    public interface IJobOfferRepository
    {
        Task<bool> Delete(int id);
        Task<IEnumerable<JobOffer>> GetAttendees();
        Task<int> Insert(JobOffer jfs);
        Task<bool> Update(JobOffer jOFFER);
    }
}