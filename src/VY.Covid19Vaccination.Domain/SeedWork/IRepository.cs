using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VY.Covid19Vaccination.Domain.SeedWork
{
    public interface IRepository<T> where T : BaseEntity
    {
        T Add(T Entity);
    }
}
