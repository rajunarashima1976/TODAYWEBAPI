using CBA.Training.Talmate.Api.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBA.Training.Talmate.Api.RecommendationService
{
    public interface IRecommendationService
    {
        Task<IQueryable<ResourceDetail>> Seek();
        Task<bool> RouteToPM(List<Recommendation> recommendation);
        Task<IQueryable<Recommendation>> Get();
        Task<bool> Accept(int Id);
        Task<bool> Reject(int Id);
    }
}
