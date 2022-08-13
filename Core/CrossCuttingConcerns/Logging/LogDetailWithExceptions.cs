using System;
using System.Collections.Generic;
using System.Text;

namespace Core.CrossCuttingConcerns.Logging
{
    public class LogDetailWithExceptions : LogDetail
    {
        public string ExceptionMessage { get; set; }
    }
}
