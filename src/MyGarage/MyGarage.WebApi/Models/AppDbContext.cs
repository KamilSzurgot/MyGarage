using System;
using MyGarage.Shared;
using Microsoft.EntityFrameworkCore;

namespace MyGarage.WebApi.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<JobCategory> JobCategories { get; set; }
        public DbSet<Repair> Repairs { get; set; }
        public DbSet<Client> Clients { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<JobCategory>().HasData(new JobCategory() { JobCategoryId = 1, JobCategoryName = "Electromechanic" });
            modelBuilder.Entity<JobCategory>().HasData(new JobCategory() { JobCategoryId = 2, JobCategoryName = "Mechanic" });
            modelBuilder.Entity<JobCategory>().HasData(new JobCategory() { JobCategoryId = 3, JobCategoryName = "Accountant" });
            modelBuilder.Entity<JobCategory>().HasData(new JobCategory() { JobCategoryId = 4, JobCategoryName = "Car tinsmith" });
            modelBuilder.Entity<JobCategory>().HasData(new JobCategory() { JobCategoryId = 5, JobCategoryName = "Car painter" });
            modelBuilder.Entity<JobCategory>().HasData(new JobCategory() { JobCategoryId = 6, JobCategoryName = "Customer service office" });

            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 1,
                BirthDate = new DateTime(1979, 1, 16),
                City = "Brussels",
                Email = "bethany@bethanyspieshop.com",
                FirstName = "Bethany",
                LastName = "Smith",
                PhoneNumber = "324777888773",
                Street = "Grote Markt 1",
                Zip = "1000",
                JobCategoryId = 1,
                Comment = "Lorem Ipsum",
                ExitDate = null,
                JoinedDate = new DateTime(2015, 3, 1)
            });

            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                BirthDate = new DateTime(1979, 1, 16),
                City = "Antwerp",
                Email = "gill@bethanyspieshop.com",
                EmployeeId = 2,
                FirstName = "Gill",
                LastName = "Cleeren",
                PhoneNumber = "33999909923",
                Street = "New Street",
                Zip = "2000",
                JobCategoryId = 2,
                Comment = "Lorem Ipsum",
                ExitDate = null,
                JoinedDate = new DateTime(2017, 12, 24)
            });

            modelBuilder.Entity<Repair>().HasData(new Repair
            {
                RepairId = 1,
                Name = "Wojciech Szurgot",
                Email = "wojciech.sz2@o2.pl",
                CarInfo = "Volkswagen Ogór",
                PhoneNumber = "123456789",
                Comment = "Wymiana silnika"
            });

            modelBuilder.Entity<Client>().HasData(new Client
            {
                ClientId = 1,
                Name = "Dominika Maćkowiak",
                Email = "mackowiak.dominika@onet.pl",
                PhoneNumber = "123456789",
                Comment = "Po naprawie przynosi ciasto",
                IsGood = true
            });

            modelBuilder.Entity<Client>().HasData(new Client
            {
                ClientId = 2,
                Name = "Bartosz Jakubski",
                Email = "proallone76@gmail.com",
                PhoneNumber = "123456789",
                Comment = "Nasrał mi do ryżu",
                IsGood = false
            });
        }
    }
}
