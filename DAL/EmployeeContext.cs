using Models;
using Microsoft.Extensions.DependencyInjection;
using System;
using Microsoft.EntityFrameworkCore;
namespace DAL{
class EmployeeContext : DbContext{

    public EmployeeContext(DbContextOptions<EmployeeContext> options):base(options){

    }
    
    public DbSet<Employee>employees{get;set;}

}
}