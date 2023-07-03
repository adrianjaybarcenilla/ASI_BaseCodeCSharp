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
    }
}
