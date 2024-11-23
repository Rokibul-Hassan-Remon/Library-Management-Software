using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSoftwareModels.Business_Model;
using LibraryManagementSoftwareModels.Entities;
namespace LibraryManagementSoftwareServices.IServices
{
	public interface IStudentService
	{
		Task<IEnumerable<StudentViewModel>> GetAllAsync();
		Task<StudentViewModel> GetByIdAsync(int id);

		Task UpdateAsync(StudentViewModel entity);
		Task DeleteAsync(int id);
		Task AddAsync(StudentViewModel entity);
	}
}
