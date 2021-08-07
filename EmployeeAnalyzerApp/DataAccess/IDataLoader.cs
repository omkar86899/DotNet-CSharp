using System.Collections.Generic;

namespace EmployeeAnalyzerApp.DataAccess
{
    public interface IDataLoader
    {
        List<Employee> GetEmployees();
    }
}
