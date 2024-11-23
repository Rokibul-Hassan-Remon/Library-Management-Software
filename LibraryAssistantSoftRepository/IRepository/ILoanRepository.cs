using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSoftwareModels.Entities;

namespace LibraryManagementSoftwareRepository.IRepository
{
	public  interface ILoanRepository
	{
		Task<IEnumerable<Loan>> GetAllAsync();
		Task<Loan> GetByIdAsync(int id);

		Task UpdateAsync(Loan entity);
		Task DeleteAsync(int id);
		Task AddAsync(Loan entity);
	}
}
