using Basecode.Data.Models;

namespace Basecode.Data.Interfaces{
    public interface IJobOpeningService{
        List<JobOpening> RetreiveAll();
        void Add(JobOpening jobOpening);
    }
}