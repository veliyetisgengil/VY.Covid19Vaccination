using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VY.Covid19Vaccination.Domain.SeedWork;

namespace VY.Covid19Vaccination.Domain.AggregateModels.Covid19Models
{
    public class Covid19 : BaseEntity
    {
        public int SEQID { get; set; }
        public string CITY { get; set; }
        public string CITY2 { get; set; }
        public int _1DOSE { get; set; }
        public int _2DOSE { get; set; }
        public int _TOTAL { get; set; }
        public int POPULATION { get; set; }
        public int DIFF_1DOSE { get; set; }
        public int DIFF_2DOSE { get; set; }
        public int DIFF_TOTAL { get; set; }
        public int PREVID { get; set; }
    }
}
