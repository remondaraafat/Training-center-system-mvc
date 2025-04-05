using lab2.Models;

namespace lab2.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private Context _context;

        public CourseRepository(Context context)
        {
            _context = context;
        }
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Course> GetAll()
        {
            List<Course> CrsList = _context.Courses.ToList();
            return CrsList;
        }

        public Course GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Course GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public void Insert(Course obj)
        {
            _context.Courses.Add(obj);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Course obj)
        {
            throw new NotImplementedException();
        }
    }
}
