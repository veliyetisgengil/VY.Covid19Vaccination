using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VY.Covid19Vaccination.Application.Result;

namespace VY.Covid19Vaccination.Infrastructure.Result
{
   public class Result : IResult
    {
        public Result(bool success,string message):this(success)
        {
            Message = message;
        }
        public Result(bool success)
        {
            Success = success;
        }
        public bool Success   {get;}
        public string Message { get; }
    }
}
