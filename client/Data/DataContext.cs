﻿using EmployeeListProject.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeListProject.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Employee> Employees { get; set; }


    }
}
