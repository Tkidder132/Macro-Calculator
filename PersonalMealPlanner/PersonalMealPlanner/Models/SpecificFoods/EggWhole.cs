namespace PersonalMealPlanner.Models.SpecificFoods
{
    public class EggWhole : Food
    {
        public EggWhole()
        {
            Name = "Egg Whole";
            CreateSingleServing();
        }

        private void CreateSingleServing()
        {
            singleServing = new SingleServing()
            {
                Calories = 66,
                GramsProtein = 5.8,
                GramsCarbs = .5,
                GramsFat = 4,
                SizeInGrams = 92
            };
        }
    }
}