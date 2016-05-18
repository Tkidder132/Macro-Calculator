namespace PersonalMealPlanner.Models.SpecificFoods
{
    public class Chicken : Food
    {
        public Chicken()
        {
            Name = "Chicken";
            CreateSingleServing();
            CalculateNutritionValues();
        }

        private void CreateSingleServing()
        {
            singleServing = new SingleServing()
            {
                Calories = 120,
                GramsProtein = 23,
                GramsCarbs = 0,
                GramsFat = 2.5,
                SizeInGrams = 112
            };
        }
    }
}
