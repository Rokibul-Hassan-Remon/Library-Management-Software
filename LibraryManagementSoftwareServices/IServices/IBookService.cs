using LibraryManagementSoftwareModels.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSoftwareServices.IServices
{
	public  interface IBookService
	{
		Task<IEnumerable<Book>> GetAllAsync();
		Task<Book>GetByIdAsync(int id);

		Task AddAsync(Book entity);
		Task UpdateAsync(Book entity);
		Task DeleteAsync(int id);
	}
}
