using LibraryManagementSoftwareServices.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSoftwareRepository.IRepository;
using LibraryManagementSoftwareRepository.Repository;
using LibraryManagementSoftwareModels.Entities;


namespace LibraryManagementSoftwareServices.Services
{
	public class CategoryService(ICategoryRepository categoryrepository) : ICategoryService
	{
		private readonly ICategoryRepository _categoryrepository = categoryrepository;

		public async Task<IEnumerable<Category> > GetAllAsync()
        {
            var list = await _categoryrepository.GetAllAsync();
            return list;
        }

        public async Task<Category> GetByIdAsync(int id)
        {
            var ojb = await _categoryrepository.GetByIdAsync(id);
            return ojb;
        }

        public async Task UpdateAsync(Category entity)
        {
           await _categoryrepository.UpdateAsync(entity);
        }

        public async Task DeleteAsync(int id)
        {
            await _categoryrepository.DeleteAsync(id);
        }

        public async Task AddAsync(Category entity)
        {
            await _categoryrepository.AddAsync(entity);
        }

	}
}
