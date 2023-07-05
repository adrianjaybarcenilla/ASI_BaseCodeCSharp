using Basecode.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Basecode.Services.Interfaces;
using Basecode.Services.Services;
using Basecode.Data.ViewModels;
using NLog;

namespace Basecode.WebApp.Controllers
{
    public class JobOpeningController : Controller
    {
        private readonly IJobOpeningService _service;
        private static Logger _logger = LogManager.GetCurrentClassLogger();

        public JobOpeningController(IJobOpeningService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            var data = _service.RetrieveAll();
            return View(data);
        }

        [HttpPost]
        public IActionResult Add(JobOpeningViewModel jobOpeningViewModel)
        {
            var data = _service.CheckValidTitle(jobOpeningViewModel);
            //if error detected (title starts with number)
            if (data.Result)
            {
                //log the error
                _logger.Error(JobOpeningErrorHandler.SetLog(data));
            }
            //success
            if (!data.Result)
            {
                //log the success
                _logger.Trace("Job Added Successfully.");
                //passes data to service Add method
                JobOpening jobOpening = new JobOpening();
                jobOpening.Title = jobOpeningViewModel.Title;
                jobOpening.Description = jobOpeningViewModel.Description;
                jobOpening.ExperienceLevel = jobOpeningViewModel.ExperienceLevel;
                jobOpening.EmploymentType = jobOpeningViewModel.EmploymentType;
                _service.Add(jobOpening);
            }
            
            return RedirectToAction("Index");
        }
    }
}