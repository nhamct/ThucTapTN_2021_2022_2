using DUE_Complains.Configurations;
using DUE_Complains.Dtos.Complains;
using DUE_Complains.Extensions;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

#nullable disable

namespace DUE_Complains.Models
{
    public class Complains_DUEContext : IdentityDbContext <AppUser,AppRole,Guid> 
    {
        //public Complains_DUEContext()
        //{
        //}

        public Complains_DUEContext(DbContextOptions options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Configure dufng Fluent API
            modelBuilder.ApplyConfiguration(new AppConfiguration());
            modelBuilder.ApplyConfiguration(new ComplainConfiguration());
            modelBuilder.ApplyConfiguration(new DepartmentConfigurations());
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
            modelBuilder.ApplyConfiguration(new AppRolesConfigurations());
            modelBuilder.ApplyConfiguration(new AppUsersConfigurations());
            modelBuilder.ApplyConfiguration(new ImageComplainsConfigurations());
            modelBuilder.ApplyConfiguration(new StudentsConfigurations());
            //Data Seeding
            modelBuilder.Seed();

            //modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<IdentityUserClaim<Guid>>().ToTable("AppUserClaims");
            modelBuilder.Entity<IdentityUserRole<Guid>>().ToTable("AppUserRoles").HasKey(x => new {x.UserId , x.RoleId });
            modelBuilder.Entity<IdentityUserLogin<Guid>>().ToTable("AppUserLogins").HasKey(x => x.UserId);
            modelBuilder.Entity<IdentityRoleClaim<Guid>>().ToTable("AppRoleClaims");
            modelBuilder.Entity<IdentityUserToken<Guid>>().ToTable("AppUserTokens").HasKey(x => x.UserId);
            modelBuilder.Entity<ComplainsViewModel>().HasNoKey();



            //base.OnModelCreating(modelBuilder);
        }


        public virtual DbSet<Complain> Complains { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<ImageComplain> ImageComplains { get; set; }
        public virtual DbSet<AppUser> AppUser { get; set; }
        public virtual DbSet<AppRole> AppRole { get; set; }
        public virtual DbSet<AppConfig> AppConfig { get; set; }




        
    }
}
