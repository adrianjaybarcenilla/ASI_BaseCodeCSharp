using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basecode.Services.Services
{
    public class JobOpeningErrorHandler
    {
        public class LogContent
        {
            public string ErrorCode { get; set; } = ""
            public DateTime Time { get; set; }
            public string Message { get; set; } = ""
            public bool Result { get; set; } = false;
        }

        public static string SetLog(LogContent logContent)
        {
            return "Error Code: " + logContent.ErrorCode + ". Message: " + "\"" + logContent.Message + "\"";
        }
    }
}
