using LibraryManagementSoftwareModels.Entities;
using LibraryManagementSoftwareRepository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LibraryManagementSoftwareRepository.DbConfigure;
namespace LibraryManagementSoftwareRepository.Repository
{
	public class LoanRepository : ILoanRepository
	{
		private readonly LibraryManagementDbContext _context;

        public LoanRepository(LibraryManagementDbContext context)
        {
			_context = context;
        }

        public async Task AddAsync(Loan entity)
		{
			await _context.loans.AddAsync(entity);
			await _context.SaveChangesAsync();
		}

		public async Task DeleteAsync(int id)
		{
			await _context.loans.FindAsync(id);
			await _context.SaveChangesAsync();
		}

		public async Task<IEnumerable<Loan>> GetAllAsync()
		{
			var ojb = await _context.loans.ToListAsync();
			return ojb;
		}

		public async Task<Loan> GetByIdAsync(int id)
		{
			var ojb = await _context.loans.FindAsync(id);
			return ojb;
		}

		public async Task UpdateAsync(Loan entity)
		{
			_context.loans.Update(entity);
			await _context.SaveChangesAsync();
		}

	}

}
