using Basecode.Data.Interfaces;
using Basecode.Services.Interfaces;
using Basecode.Data.Repositories;
using Basecode.Data.Models;

namespace Basecode.Services.Interfaces{
    public interface IJobOpeningService{
        List<JobOpening> RetrieveAll();
        void Add(JobOpening jobOpening);
    }
}