using System.Collections.Generic;
using MyGarage.Shared;

namespace MyGarage.WebApi.Models
{
    public interface IJobCategoryRepository
    {
        IEnumerable<JobCategory> GetAllJobCategories();
        JobCategory GetJobCategoryById(int jobCategoryId);
    }
}
