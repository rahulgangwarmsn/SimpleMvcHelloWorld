using SimpleMvcHelloWorld.DataAccessLayer;
namespace SimpleMvcHelloWorld.Models

{
    public class EmployeeBusinessLayer
    {

       
        public List<Employee> GetEmployees()
        {
            SalesERPDAL salesDal = new SalesERPDAL();
            return salesDal.Employees.ToList();

        }
    }
}
