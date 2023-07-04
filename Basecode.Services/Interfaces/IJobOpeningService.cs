using Basecode.Data.Models;

namespace Basecode.Services.Interfaces{
    public interface IJobOpeningService{
        List<JobOpening> RetrieveAll();
        void Add(JobOpening jobOpening);
    }
}