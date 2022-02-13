using System.Collections.Generic;
using VY.Covid19Vaccination.Domain.AggregateModels.Covid19Models;
using VY.Covid19Vaccination.Domain.SeedWork;

namespace VY.Covid19Vaccination.Application.Repository
{
    public interface ICovid19Repository : IRepository<Covid19>
    {
        //special method for covid19 
        public Covid19 GetByCity(string city);
        public List<Covid19> GetList();
    }
}
