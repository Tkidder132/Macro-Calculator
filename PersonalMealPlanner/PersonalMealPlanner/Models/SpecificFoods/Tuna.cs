using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalMealPlanner.Models.SpecificFoods
{
    public class Tuna : Food
    {
        public Tuna()
        {
            Name = "Tuna";
            CreateSingleServing();
        }

        private void CreateSingleServing()
        {
            singleServing = new SingleServing()
            {
                Calories = 157,
                GramsProtein = 25,
                GramsCarbs = 0,
                GramsFat = 5,
                SizeInGrams = 85
            };
        }
    }
}
