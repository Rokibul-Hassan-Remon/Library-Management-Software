using LibraryManagementSoftwareRepository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSoftwareModels.Entities;
using LibraryManagementSoftwareRepository.DbConfigure;
using Microsoft.EntityFrameworkCore;


namespace LibraryManagementSoftwareRepository.Repository
{
	public class CategoryRepository(LibraryManagementDbContext context) : ICategoryRepository
	{
		private readonly LibraryManagementDbContext _context = context;

		public async Task AddAsync(Category entity)
		{
			_context.catagories.Add(entity);

			 await _context.SaveChangesAsync();
		}

		public async Task DeleteAsync(int id)
		{
			var ojb = await _context.catagories.FindAsync(id);
			if(ojb != null)
			{
				_context.catagories.RemoveRange(ojb);
				await _context.SaveChangesAsync();
			}
		}

		public async Task<IEnumerable<Category>> GetAllAsync()
		{
			var ojb = await _context.catagories.ToListAsync();
			return ojb;
		}

		public async Task<Category> GetByIdAsync(int id)
		{
			var ojb = await _context.catagories.FindAsync(id);
			return ojb;
            
		}

		public async Task UpdateAsync(Category entity)
		{
			 _context.catagories.Update(entity);
			await _context.SaveChangesAsync();
		}

		
	}


}
