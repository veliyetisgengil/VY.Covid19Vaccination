using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VY.Covid19Vaccination.Application.Repository;
using VY.Covid19Vaccination.Domain.AggregateModels.Covid19Models;
using VY.Covid19Vaccination.Infrastructure.Utilities;

namespace VY.Covid19Vaccination.Infrastrucure.Utilites
{
    public static class Covid19DataProcess
    {
        

        
        public static List<Covid19> GetDataFromJson()
        {
            using (StreamReader r = new StreamReader("../../covid19data.json"))
            {
                string json = r.ReadToEnd();
                List<Covid19> items = JsonConvert.DeserializeObject<List<Covid19>>(json);
                return items;
            }
        }
         
    }
}
