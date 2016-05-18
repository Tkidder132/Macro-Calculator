namespace PersonalMealPlanner.Models.SpecificFoods
{
    public class Tilapia : Food
    {
        public Tilapia()
        {
            Name = "Tilapia";
            CreateSingleServing();
        }

        private void CreateSingleServing()
        {
            singleServing = new SingleServing()
            {
                Calories = 112,
                GramsProtein = 23,
                GramsCarbs = 0,
                GramsFat = 2.3,
                SizeInGrams = 87
            };
        }
    }
}
