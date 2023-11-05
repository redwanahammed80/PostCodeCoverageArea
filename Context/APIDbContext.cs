using LearningProject.Model;
using Microsoft.EntityFrameworkCore;

namespace LearningProject.Context
{
    public class APIDbContext : DbContext
    {
        public APIDbContext(DbContextOptions<APIDbContext> options) : base(options) { }
        public DbSet<Department> Departments
        {
            get;
            set;
        }
        public DbSet<Employee> Employees
        {
            get;
            set;
        }
        public DbSet<PostCode> postCodes
        {
            get;
            set;
        }
    }
}
