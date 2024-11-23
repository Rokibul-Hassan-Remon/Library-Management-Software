using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSoftwareModels.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
namespace LibraryManagementSoftwareRepository.DbConfigure
{
	public class LibraryManagementDbContext : IdentityDbContext< ApplicationUser >
	{
        public LibraryManagementDbContext(DbContextOptions<LibraryManagementDbContext>options): base(options)
        {
            
        }

		public DbSet<Book> books { get; set; }
        public DbSet<Category> catagories { get; set; }
        public DbSet<Loan> loans { get; set; }
        public DbSet<Staff> staffs { get; set; }
        public DbSet<Student> students { get; set; }
    }
}
