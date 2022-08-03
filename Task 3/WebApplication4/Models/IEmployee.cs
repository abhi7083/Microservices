namespace WebApplication4.Models
{
    public interface IEmployee
    {
        public List<employee> getAllEmployees();

        public employee getEmployeeById(int id);

        public employee createEmployee(employee obj);
        public employee updateEmployee(employee obj);

        public employee deleteEmployee(int id);
    }
}
