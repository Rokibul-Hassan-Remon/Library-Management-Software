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
	public class BookRepository : IBookRepository
	{
		public  LibraryManagementDbContext _context;

        public BookRepository(LibraryManagementDbContext context)
        {
            _context = context;
        }

		public async Task AddAsync(Book entity)
		{		
			 _context.books.Add(entity);
			await _context.SaveChangesAsync( );			
		}

		public async Task DeleteAsync(int id)
		{	
			/// var ob = _context.books.FirstOrDefault(x=> x.Id==id);
			var ojb = await _context.books.FindAsync(id);

			if(ojb != null)
			{
				 _context.books.Remove(ojb);
				await _context.SaveChangesAsync();
			}
			
		}

		public async Task< IEnumerable<Book>> GetAllAsync()
		{			
			var list = await _context.books.ToListAsync();
			return list;			
		}

		public async Task<Book> GetByIdAsync(int id)
		{
			var ojb = await _context.books.FindAsync(id);
			return ojb;
		} 

		public async Task UpdateAsync(Book entity)
		{
			 _context.books.Update(entity);
			 await _context.SaveChangesAsync();
		
		}

	}


}
