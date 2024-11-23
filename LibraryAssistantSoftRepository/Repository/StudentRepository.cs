using LibraryManagementSoftwareModels.Entities;
using LibraryManagementSoftwareRepository.DbConfigure;
using LibraryManagementSoftwareRepository.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSoftwareRepository.Repository
{
	public class StudentRepository : IStudentRepository
	{
		private readonly LibraryManagementDbContext _context;

        public StudentRepository(LibraryManagementDbContext context)
        {
			_context = context;   
        }

        public async Task AddAsync(Student entity)
		{
			_context.students.Add(entity);
			 await _context.SaveChangesAsync();
		}

		public async Task DeleteAsync(int id)
		{
			var ojb = await _context.students.FindAsync(id);
			if(ojb != null)
			{
				_context.students.Remove(ojb);
				await _context.SaveChangesAsync();
			}
		}

		public async Task< IEnumerable<Student> >GetAllAsync()
		{
			var list = await _context.students.ToListAsync();
			return list;
		}

		public async Task<Student> GetByIdAsync(int id)
		{
			var ojb =  await _context.students.FindAsync(id);
			return ojb;
		}

		public async Task UpdateAsync(Student entity)
		{
		    var ojb = _context.students.Update(entity);
			await _context.SaveChangesAsync();
		}
	}
}
