using Basecode.Data.Interfaces;
using Basecode.Services.Interfaces;
using Basecode.Data.Repositories;
using Basecode.Data.Models;
using Basecode.Data.ViewModels;
using static Basecode.Services.Services.JobOpeningErrorHandler;

namespace Basecode.Services.Interfaces{
    public interface IJobOpeningService{
        List<JobOpening> RetrieveAll();
        void Add(JobOpening jobOpening);
        LogContent CheckValidTitle(JobOpeningViewModel jobOpeningViewModel);
    }
}