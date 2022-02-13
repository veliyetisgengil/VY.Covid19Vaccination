using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VY.Covid19Vaccination.Infrastructure.Result
{
    public class SuccessResult :Result
    {
        public SuccessResult(string message) : base(true,message)
        {

        }
        public SuccessResult():base(true)
        {

        }
    }
}
