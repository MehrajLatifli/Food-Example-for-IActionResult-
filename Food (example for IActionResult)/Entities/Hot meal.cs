using System.ComponentModel.DataAnnotations;

namespace Food__example_for_IActionResult_.Entities
{
    public class Hot_meal
    {
        [Key]
        public int Id { get; set; } 
        public string Name { get; set; }

        public string Image_path { get; set; }

        public Hot_meal()
        {

        }
    }
}
