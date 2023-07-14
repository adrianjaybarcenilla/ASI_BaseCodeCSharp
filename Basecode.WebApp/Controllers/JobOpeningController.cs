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
        //--attributes
        private readonly IJobOpeningService _service;
        private static Logger _logger = LogManager.GetCurrentClassLogger();
        //--constructors
        public JobOpeningController(IJobOpeningService service)
        {
            _service = service;
        }
        //--page redirect methods
        public IActionResult Index()
        {
            var data = _service.RetrieveAll();
            return View(data);
        }
        public IActionResult DeleteView(int id)
        {
            var data = _service.GetByID(id);
            return View(data);
        }
        public IActionResult UpdateView(int id)
        {
            var data = _service.GetByID(id);
            return View(data);
        }
        //--CRUD methods
        [HttpPost]
        public IActionResult Add(JobOpeningViewModel jobOpeningViewModel)
        {
            var data = _service.CheckValidTitle(jobOpeningViewModel);
            //if error detected (title starts with number)
            if (!data.Result)
            {
                //log the error
                _logger.Error(JobOpeningErrorHandler.SetLog(data));
            }
            //success
            else
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
        [HttpPost]
        public IActionResult Delete(int id)
        {
            _service.Delete(id);

            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Update(JobOpening jobOpening)
        {
            _service.Update(jobOpening);

            return RedirectToAction("Index");
        }
        [HttpGet]
        public JobOpening GetByID(int id)
        {
            return _service.GetByID(id);
        }
        public JsonResult GetByIDJson(int id)
        {
            JobOpening jobOpening = GetByID(id);
            return Json(jobOpening);
        }
    }
}