using LibraryManagementSoftwareModels.Entities;
using LibraryManagementSoftwareRepository.IRepository;
using LibraryManagementSoftwareServices.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSoftwareServices.Services
{
	public class LoanService(ILoanRepository loanrepository) : ILoanService
	{
		private readonly ILoanRepository _loanrepository = loanrepository;

		public async Task AddAsync(Loan entity)
		{
			await _loanrepository.AddAsync(entity);

		}

		public async Task DeleteAsync(int id)
		{
			await _loanrepository.DeleteAsync(id);
		}

		public async Task<IEnumerable<Loan>> GetAllAsync()
		{
			return await _loanrepository.GetAllAsync();
		}

		public async Task<Loan> GetByIdAsync(int id)
		{
			return await _loanrepository.GetByIdAsync(id);
		}

		public async Task UpdateAsync(Loan entity)
		{
			await _loanrepository.UpdateAsync(entity);
		}
	}
}
