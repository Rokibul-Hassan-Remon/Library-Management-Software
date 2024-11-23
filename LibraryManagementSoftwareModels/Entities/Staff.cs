using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSoftwareModels.Entities
{
	public class Staff
	{
		[Key] public int Id { get; set; }
		public string StaffId { get; set; }
		public string StaffName { get; set; }
		public string StaffPosition { get; set; }
	}
}
