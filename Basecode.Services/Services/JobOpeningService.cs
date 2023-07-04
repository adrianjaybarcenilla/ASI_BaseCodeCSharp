using Basecode.Data.Interfaces;
using Basecode.Services.Interfaces;
using Basecode.Data.Repositories;
using Basecode.Data.Models;

namespace Basecode.Services.Services{
    public class JobOpeningService : IJobOpeningService
    {
        private readonly IJobOpeningRepository _repository;
        public JobOpeningService(IJobOpeningRepository repository)
        {
            _repository = repository;
        }

        public void Add(JobOpening jobOpening)
        {
                
        }

        public List<JobOpening> RetreiveAll()
        {
            return _repository.RetrieveAll().ToList();
        }
    }
}