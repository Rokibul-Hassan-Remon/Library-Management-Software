using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSoftwareModels.Entities
{
	public class Book
	{
		[Key]
		public int Id { get; set; }
		public String Title { get; set; }
		public String Auther { get; set; }

		public String ISBN { get; set; }
	}
}