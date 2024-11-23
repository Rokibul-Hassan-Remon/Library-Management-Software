using LibraryManagementSoftwareModels.Business_Model;
using LibraryManagementSoftwareModels.Entities;
using LibraryManagementSoftwareRepository.IRepository;
using LibraryManagementSoftwareServices.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;


namespace LibraryManagementSoftwareServices.Services
{
	public class StudentService(IStudentRepository studentrepository , IMapper mapper) : IStudentService
	{
		private readonly IStudentRepository _studentrepository = studentrepository;
		private readonly IMapper _mapper = mapper;

		public async Task AddAsync(StudentViewModel entity)
		{

			var student = _mapper.Map<Student>(entity);
			await _studentrepository.AddAsync(student);
		}

		public async Task DeleteAsync(int id)
		{
			await _studentrepository.DeleteAsync(id);
		}

		public async Task<IEnumerable<StudentViewModel>> GetAllAsync()
		{

			var obj = await _studentrepository.GetAllAsync();
			var tran_VM = _mapper.Map<List <StudentViewModel> >(obj);

			return tran_VM;
		}

		public async Task<StudentViewModel> GetByIdAsync(int id)
		{
			var obj = await _studentrepository.GetByIdAsync(id);
			var Con_VM = _mapper.Map<StudentViewModel>(obj);
			return Con_VM;
		}

		public async Task UpdateAsync(StudentViewModel entity)
		{
			var con_VM =  _mapper.Map<Student>(entity);
			await _studentrepository.UpdateAsync(con_VM);
		}
	}

	
}
