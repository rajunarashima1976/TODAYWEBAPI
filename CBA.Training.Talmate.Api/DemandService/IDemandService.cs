using System;
using CBA.Training.Talmate.Api.EntityModels;
//using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CBA.Training.Talmate.Api.DemandService
{
    public interface IDemandService
    {
        Task<IQueryable<Demand>> Get();
        Task<bool> Post(Demand demand);
    }
}
