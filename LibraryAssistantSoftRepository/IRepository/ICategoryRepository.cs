using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LibraryManagementSoftwareModels.Entities;

namespace LibraryManagementSoftwareRepository.IRepository
{
	public  interface  ICategoryRepository
	{
		Task<IEnumerable<Category>> GetAllAsync();
		Task<Category> GetByIdAsync(int id);

		Task AddAsync(Category entity);
		Task UpdateAsync(Category entity);
		Task DeleteAsync(int id);
	}
}
