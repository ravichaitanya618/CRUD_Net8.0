using System.ComponentModel.DataAnnotations;

namespace CRUD_Net8._0.Model
{
    public class Task
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage ="Title is Required")]
        public required string Title { get; set; }

        [Required(ErrorMessage = "Description is Required")]
        public required string Description { get; set; }
        public Status Status { get; set; }
    }
    public enum Status
    {
        Pending,
        Completed
    }
}
