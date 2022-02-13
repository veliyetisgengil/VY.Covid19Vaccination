using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VY.Covid19Vaccination.Application.Repository;
using VY.Covid19Vaccination.Infrastrucure.Utilites;

namespace VY.Covid19Vaccination.Presentation.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CovidController : ControllerBase
    {
        private readonly ILogger<CovidController> _logger;
        private readonly ICovid19Repository _covid19Repository;
        public CovidController(ILogger<CovidController> logger,ICovid19Repository covid19Repository)
        {
            _logger = logger;
            _covid19Repository = covid19Repository;
        }

        [HttpGet("UpdateDataFromJson")]
        public IActionResult UpdateDataFromJson()
        {
            try
            {
                var data = Covid19DataProcess.GetDataFromJson();

                foreach (var item in data)
                {
                    _covid19Repository.Add(item);
                }
                _logger.LogInformation("Bütün Datalar Güncellendi.");
                return Ok("Bütün Datalar Güncellendi.");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest(ex.Message);
            }
            
        }

        [HttpGet("GetCovidDataByCity")]
        public IActionResult GetCovidDataByCity(string city)
        {
            try
            {
                var data = _covid19Repository.GetByCity(city);

                _logger.LogInformation(city +"  Datası Getirildi.");

                return Ok(data);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetCovidDataAll")]
        public IActionResult GetCovidDataAll()
        {
            try
            {
                var data = _covid19Repository.GetList();

                _logger.LogInformation("Bütün Covid19 Datası Getirildi.");

                return Ok(data);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest(ex.Message);
            }

        }
    }
}
