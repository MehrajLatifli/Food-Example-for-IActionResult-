using Food__example_for_IActionResult_.Entities;
using System.Collections.Generic;

namespace Food__example_for_IActionResult_.Models
{
    public class ProductlistViewModel
    {
        public List<Drink> Drinks { get; set; }
        public List<Hot_meal> Hot_meals { get; set; }

        public List<Fast_food> Fast_foods { get; set; }

        public ProductlistViewModel()
        {

        }


    }
}
