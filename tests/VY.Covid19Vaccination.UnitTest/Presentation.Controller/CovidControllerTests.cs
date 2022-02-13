using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VY.Covid19Vaccination.Application.Repository;
using VY.Covid19Vaccination.Infrastrucure.Repository;
using VY.Covid19Vaccination.Presentation.Controllers;

namespace VY.Covid19Vaccination.UnitTest.Presentation.Controller
{
    [TestClass]
    public class CovidControllerTests
    {
        private readonly ILogger<CovidController> logger;
        private readonly ICovid19Repository covid19Repository;
        private readonly CovidController covidController;
        public CovidControllerTests()
        {
            logger = Mock.Of<ILogger<CovidController>>();
            covid19Repository = new Covid19Repository();
            covidController = new CovidController(logger, covid19Repository);
        }


    }
}
