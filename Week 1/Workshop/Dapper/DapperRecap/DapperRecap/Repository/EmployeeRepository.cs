﻿using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using Dapper;
using DapperRecap.Data;
using DapperRecap.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace DapperRecap.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private IDbConnection db;

        public EmployeeRepository(IConfiguration configuration)
        {
            this.db = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));
        }

        public Employee Find(int id)
        {
            var sql = "SELECT * FROM Employees WHERE EmployeeId = @Id";
            return db.Query<Employee>(sql, new {@Id = id}).Single();
        }

        public List<Employee> GetAll()
        {
            var sql = "SELECT * FROM Employees";
            return db.Query<Employee>(sql).ToList();
        }

        public Employee Add(Employee employee)
        {
            var sql =
                "INSERT INTO Employees (Name,Title,Email,Phone,CompanyId) VALUES (@Name,@Title,@Email,@Phone,@CompanyId);"
            + "SELECT CAST(SCOPE_IDENTITY() as int);";
            var id = db.Query<int>(sql,employee).Single();
            employee.EmployeeId = id;
            return employee;
        }

        public Employee Update(Employee employee)
        {
            var sql =
                "UPDATE Employees SET Name = @Name,Title = @Title,Email=@Email,Phone=@Phone,CompanyId=@CompanyId WHERE EmployeeId = @EmployeeId";
            db.Execute(sql,employee );
            return employee;
        }

        public void Remove(int id)
        {
            var sql = "DELETE FROM Employees WHERE EmployeeId = @Id";
            db.Execute(sql, new {id});
        }
    }
}