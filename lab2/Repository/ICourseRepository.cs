using lab2.Models;

namespace lab2.Repository
{
    public interface ICourseRepository : IRepository<Course>
    {
        Course GetByName(string name);
    }
}
