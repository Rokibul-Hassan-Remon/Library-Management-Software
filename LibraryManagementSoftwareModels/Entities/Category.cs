using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSoftwareModels.Entities
{
	public class Category
	{
		[Key] public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public String CreatedDate {  get; set; }
	}
}
