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
            jobOpening.CreatedBy = System.Environment.UserName;
            jobOpening.CreatedTime = DateTime.Now;
            jobOpening.UpdatedBy = System.Environment.UserName;
            jobOpening.UpdatedTime = DateTime.Now;
        
            _repository.Add(jobOpening);
        }

        public List<JobOpening> RetrieveAll()
        {
            return _repository.RetrieveAll().ToList();
        }
    }
}