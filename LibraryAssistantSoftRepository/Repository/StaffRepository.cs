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
	public class StaffRepository : IStaffRepository
	{
		private readonly LibraryManagementDbContext _context;

        public StaffRepository(LibraryManagementDbContext context)
        {
			_context = context;
        }

        public async Task AddAsync(Staff entity)
		{
			 await _context.staffs.AddAsync(entity);
			 await _context.SaveChangesAsync();			
		}

		public async Task DeleteAsync(int id)
		{
			var ojb = await _context.staffs.FindAsync(id);
			if(ojb != null)
			{
				_context.staffs.RemoveRange(ojb);
				await _context.SaveChangesAsync();
			}
		}

		public async Task<IEnumerable<Staff>> GetAllAsync()
		{
		  return await _context.staffs.ToListAsync();
		}

		public async Task<Staff> GetByIdAsync(int id)
		{
			return await _context.staffs.FindAsync(id);
		}

		public async Task UpdateAsync(Staff entity)
		{
			_context.staffs.Update(entity);
			await _context.SaveChangesAsync();
		}
	}
}
