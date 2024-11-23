using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSoftwareModels.Entities;

namespace LibraryManagementSoftwareRepository.IRepository
{
	public interface IStudentRepository
	{
		Task<IEnumerable<Student>> GetAllAsync();
		Task<Student> GetByIdAsync(int id);

		Task UpdateAsync(Student entity);
		Task DeleteAsync(int id);
		Task AddAsync(Student entity);

	}
}
