using Basecode.Data.Interfaces;
using Basecode.Services.Interfaces;
using Basecode.Data.Repositories;
using Basecode.Data.Models;
using Basecode.Data.ViewModels;

namespace Basecode.Services.Services{
    public class JobOpeningService : JobOpeningErrorHandler, IJobOpeningService
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

        public LogContent CheckValidTitle(JobOpeningViewModel jobOpeningViewModel)
        {
            LogContent logContent = new LogContent();

            if (char.IsDigit(jobOpeningViewModel.Title[0]))
            {
                logContent.ErrorCode = "Invalid Title.";
                logContent.Message = "Title starts with a number.";
                logContent.Result = true;
            }

            return logContent;
        }
    }
}