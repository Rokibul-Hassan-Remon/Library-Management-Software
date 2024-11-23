using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSoftwareModels.Entities;

namespace LibraryManagementSoftwareRepository.IRepository
{
	public  interface IStaffRepository
	{
		Task<IEnumerable<Staff>> GetAllAsync();
		Task<Staff> GetByIdAsync(int id);

		Task DeleteAsync(int id);
		Task UpdateAsync(Staff entity);
		Task AddAsync(Staff entity);
	}
}
