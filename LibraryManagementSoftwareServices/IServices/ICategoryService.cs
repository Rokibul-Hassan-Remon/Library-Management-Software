
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSoftwareRepository.Repository;
using LibraryManagementSoftwareModels.Entities;

namespace LibraryManagementSoftwareServices.IServices
{
	public interface ICategoryService
	{
		 Task<IEnumerable<Category>>GetAllAsync();
		 Task<Category> GetByIdAsync(int id);

		Task DeleteAsync(int id);
		Task UpdateAsync(Category entity);
		Task AddAsync(Category entity);
		 
	}
}
