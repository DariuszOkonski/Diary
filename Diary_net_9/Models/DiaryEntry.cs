using System.ComponentModel.DataAnnotations;

namespace Diary_net_9.Models
{
    public class DiaryEntry
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter a title!")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Title must be between 3 and 100 characters!")]
        public string Title { get; set; } = string.Empty;
        [Required(ErrorMessage = "Please enter a content!")]
        public string Content { get; set; } = string.Empty;
        [Required(ErrorMessage = "Please enter a date!")]
        public DateTime Created { get; set; } = DateTime.Now;
    }
}
