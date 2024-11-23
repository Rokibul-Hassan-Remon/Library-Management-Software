using LibraryManagementSoftwareModels.Entities;

namespace LibraryManagementSoftwareRepository.Repository
{
	public interface ICatagoryRepository
	{
		Task AddAsync(Category entity);
		Task DeleteAsync(int id);
		Task<IEnumerable<Category>> GetAllAsync();
		Task<Category> GetByIdAsync(int id);
		Task UpdateAsync(Category entity);
	}
}