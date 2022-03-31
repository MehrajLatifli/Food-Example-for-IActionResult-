using System.ComponentModel.DataAnnotations;

namespace Food__example_for_IActionResult_.Entities
{
    public class Drink
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public string Image_path { get; set; }

        public Drink()
        {

        }
    }
}
