using Basecode.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Basecode.Services.Interfaces;
using Basecode.Services.Services;
using Basecode.Data.ViewModels;

namespace Basecode.WebApp.Controllers
{
    public class JobOpeningController : Controller
    {
        private readonly IJobOpeningService _service;

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
            JobOpening jobOpening = new JobOpening();
            jobOpening.Title = jobOpeningViewModel.Title;
            jobOpening.Description = jobOpeningViewModel.Description;
            jobOpening.ExperienceLevel = jobOpeningViewModel.ExperienceLevel;
            jobOpening.EmploymentType = jobOpeningViewModel.EmploymentType;
            _service.Add(jobOpening);
            return RedirectToAction("Index");
        }
    }
}