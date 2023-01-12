using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Programowanie_Zaawansowane_Projekt.Models
{
    [Table("Tasks")]
    public class TaskModel
    {
        [Key]

        public int TaskId { get; set; }
        [DisplayName("Task Name")]
        [Required(ErrorMessage = "Name is Required")]
        [MaxLength(50)]
        public string Name { get; set; }
        [DisplayName("Task Description")]
        [MaxLength(1500)]
        public string Description { get; set; }
        public bool IsCompleted { get; set; }

    }
}