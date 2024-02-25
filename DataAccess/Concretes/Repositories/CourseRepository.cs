using Core.DataAccess.EntityFramework;
using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework.Contexts;
using Entities.Concretes;

namespace DataAccess.Concretes.Repositories;

public class CourseRepository : EfRepositoryBase<Course, Guid, BaseDbContext>, ICourseRepository
{
    public CourseRepository(BaseDbContext context) : base(context)
    {
    }
}
