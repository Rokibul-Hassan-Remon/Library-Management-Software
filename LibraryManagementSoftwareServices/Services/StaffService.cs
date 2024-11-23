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
	public class StaffService(IStaffRepository staffrepository) : IStaffService
	{
		private readonly IStaffRepository _staffrepository = staffrepository;

		public async Task AddAsync(Staff entity)
		{
			await _staffrepository.AddAsync(entity);
		}

		public async Task DeleteAsync(int id)
		{
			await _staffrepository.DeleteAsync(id);
		}

		public async Task<IEnumerable<Staff>> GetAllAsync()
		{
			var obj = await _staffrepository.GetAllAsync();
			return obj;
		}

		public async Task<Staff> GetByIdAsync(int id)
		{
			var obj = await _staffrepository.GetByIdAsync(id);
			return obj;
		}

		public async Task UpdateAsync(Staff entity)
		{
			await _staffrepository.UpdateAsync(entity);
		}
	}
}
