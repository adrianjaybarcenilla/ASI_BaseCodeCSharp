using Basecode.Data.Interfaces;
using Basecode.Services.Interfaces;
using Basecode.Data.Repositories;
using Basecode.Data.Models;
using Basecode.Data.ViewModels;

namespace Basecode.Services.Services{
    public class JobOpeningService : JobOpeningErrorHandler, IJobOpeningService
    {
        //--attributes
        private readonly IJobOpeningRepository _repository;
        //--constructors
        public JobOpeningService(IJobOpeningRepository repository)
        {
            _repository = repository;
        }
        //--CRUD methods
        public void Add(JobOpening jobOpening)
        {
            //computer generated values
            jobOpening.CreatedBy = System.Environment.UserName;
            jobOpening.CreatedTime = DateTime.Now;
            jobOpening.UpdatedBy = System.Environment.UserName;
            jobOpening.UpdatedTime = DateTime.Now;
            //pass to repository add function
            _repository.Add(jobOpening);
        }
        public List<JobOpening> RetrieveAll()
        {
            return _repository.RetrieveAll().ToList();
        }
        public void Delete(int id)
        {
            _repository.Delete(id);
        }
        public JobOpening GetByID(int id)
        {
            return _repository.GetByID(id);
        }
        public void Update(JobOpening jobOpening)
        {
            _repository.Update(jobOpening);
        }
        //--error handling
        public LogContent CheckValidTitle(JobOpeningViewModel jobOpeningViewModel)
        {
            LogContent logContent = new LogContent();

            if (char.IsDigit(jobOpeningViewModel.Title[0]))
            {
                logContent.ErrorCode = "Invalid Title.";
                logContent.Message = "Title starts with a number.";
                logContent.Result = false;
            }

            return logContent;
        }
    }
}