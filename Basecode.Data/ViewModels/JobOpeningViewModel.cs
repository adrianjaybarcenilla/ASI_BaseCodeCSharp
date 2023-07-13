﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basecode.Data.ViewModels
{
    public class JobOpeningViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public string EmploymentType { get; set; }
        public string ExperienceLevel { get; set; }
        public DateTime? CreatedTime { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? UpdatedTime { get; set; }
        public string? UpdatedBy { get; set; }
    }
}
