using Basecode.Data.Interfaces;
using Basecode.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basecode.Data.Repositories
{
    public class JobOpeningRepository : BaseRepository, IJobOpeningRepository
    {
        //attributes
        private readonly BasecodeContext _context;
        //constructors
        public JobOpeningRepository(IUnitOfWork unitOfWork, BasecodeContext context) : base(unitOfWork)
        {
            _context = context;
        }
        //CRUD methods
        public IQueryable<JobOpening> RetrieveAll()
        {
            return this.GetDbSet<JobOpening>();
        }
        public void Add(JobOpening jobOpening)
        {
            _context.JobOpening.Add(jobOpening);
            _context.SaveChanges();
        }
        public JobOpening GetByID(int id)
        {
            return _context.JobOpening.Find(id);
        }
        public void Update(JobOpening jobOpening)
        {
            _context.JobOpening.Update(jobOpening);
            _context.SaveChanges();
        }
        public void Delete(int id)
        {
            var data = _context.JobOpening.Find(id);
            if(data != null)
            {
                _context.JobOpening.Remove(data);
                _context.SaveChanges();
            }
        }
    }
}
