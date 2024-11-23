using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSoftwareModels.Entities;
using LibraryManagementSoftwareRepository.Repository;

namespace LibraryManagementSoftwareServices.IServices
{
	public interface IStaffService
	{
		Task<IEnumerable<Staff>> GetAllAsync();
		Task<Staff> GetByIdAsync(int id);

		Task UpdateAsync(Staff entity);
		Task DeleteAsync(int id);
		Task AddAsync(Staff entity);
	}
}
