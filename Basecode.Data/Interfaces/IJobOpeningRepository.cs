using System;
using System.Collections.Generic;
using Basecode.Data.Models;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basecode.Data.Interfaces
{
    public interface IJobOpeningRepository
    {
        IQueryable<JobOpening> RetrieveAll();
        void Add(JobOpening jobOpening);
        JobOpening GetByID(int id);
        void Update(JobOpening jobOpening);
        void Delete(int id);
    }
}
