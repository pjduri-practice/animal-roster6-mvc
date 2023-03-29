using System.ComponentModel.DataAnnotations;

namespace AnimalRoster6.ViewModels
{
    public class AddAnimalViewModel
    {
        [Required(ErrorMessage = "Hey buddy, I need a name.  Thanks.  🙂")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Not so fast.  Names must be between 3 and 50 characters in length.")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Just do it.")]
        [StringLength(50, ErrorMessage = "Max char length: 50")]
        public string? Species { get; set; }

        [Required(ErrorMessage = "Just write something.")]
        [StringLength(255, ErrorMessage = "That might be a bit too much.")]
        public string? Description { get; set; }

        [Required(ErrorMessage = "Need a pic here.")]
        [Url(ErrorMessage = "Must be a proper url")]
        public string? ImgUrl { get; set;}

    }
}
