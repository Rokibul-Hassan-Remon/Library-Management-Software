using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSoftwareModels.Entities
{ 

	public class Student
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Mobile { get; set; }
    }
}
