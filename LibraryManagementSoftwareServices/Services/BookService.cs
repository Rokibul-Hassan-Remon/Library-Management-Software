using LibraryManagementSoftwareModels.Entities;
using LibraryManagementSoftwareRepository.DbConfigure;
using LibraryManagementSoftwareRepository.IRepository;
using LibraryManagementSoftwareRepository.Repository;
using LibraryManagementSoftwareServices.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSoftwareServices.Services
{
	

	public class BookService(IBookRepository bookrepository) : IBookService
	{
		private readonly IBookRepository _bookrepository = bookrepository;

		public async Task AddAsync(Book entity)
		{
			 await _bookrepository.AddAsync(entity) ;
		}

		public async Task DeleteAsync(int id)
		{
			await _bookrepository.DeleteAsync(id);
		}

		public async Task<IEnumerable<Book>> GetAllAsync()
		{
			var list = await _bookrepository.GetAllAsync();
			return list;

		}

		public async Task<Book> GetByIdAsync(int id)
		{
			var ojb= await _bookrepository.GetByIdAsync(id);
			return ojb;
		}

		public async Task UpdateAsync(Book entity)
		{
			 await _bookrepository.UpdateAsync(entity);
		}
	}
}
