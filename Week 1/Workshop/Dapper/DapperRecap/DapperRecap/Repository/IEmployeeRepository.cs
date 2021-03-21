using System.Collections.Generic;
using DapperRecap.Models;

namespace DapperRecap.Repository
{
    public interface IEmployeeRepository
    {
        Employee Find(int id);
        List<Employee> GetAll();
        Employee Add(Employee employee);
        Employee Update(Employee employee);
        void Remove(int id);
    }
}