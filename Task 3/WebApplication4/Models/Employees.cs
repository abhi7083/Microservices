namespace WebApplication4.Models
{
    public class Employees : IEmployee
    {
        EmployeeDbContext _context;

        public Employees(EmployeeDbContext context) 
        {
            _context = context; 
        }
        public employee createEmployee(employee obj)
        {
            _context.employees.Add(obj);
            _context.SaveChanges();
            return obj;
        }

        public employee deleteEmployee(int id)
        {
            var obj = _context.employees.Find(id);
            _context.employees.Remove(obj);
            _context.SaveChanges();
            return obj;
        }

        public List<employee> getAllEmployees()
        {
            return _context.employees.ToList();
        }

        public employee getEmployeeById(int id)
        {

            return _context.employees.Find(id);

        }

        public employee updateEmployee(employee obj)
        {
            _context.employees.Update(obj);
            _context.SaveChanges();
            return obj;
        }
    }
}
