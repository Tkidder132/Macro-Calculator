namespace PersonalMealPlanner.Models.SpecificFoods
{
    public class Broccoli : Food
    {
        public Broccoli()
        {
            Name = "Broccoli";
            CreateSingleServing();
            CalculateNutritionValues();
        }

        private void CreateSingleServing()
        {
            singleServing = new SingleServing()
            {
                Calories = 30,
                GramsProtein = 1,
                GramsCarbs = 4,
                GramsFat = 0,
                SizeInGrams = 85
            };
        }
    }
}
