using lab2.Models;

namespace lab2.Repository
{
    public class DepartmentRepository : IDepartmntRepository
    {
        private Context _context;

        public DepartmentRepository(Context context)
        {
            _context = context;
        }
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Department> GetAll()
        {
            List<Department>departments= _context.Departments.ToList();
            return departments;
        }

        public Department GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Department obj)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(Department obj)
        {
            throw new NotImplementedException();
        }
    }
}
