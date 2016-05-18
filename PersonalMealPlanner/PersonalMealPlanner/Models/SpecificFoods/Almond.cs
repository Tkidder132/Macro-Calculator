namespace PersonalMealPlanner.Models.SpecificFoods
{
    public class Almond : Food
    {
        public Almond()
        {
            Name = "Almonds";
            CreateSingleServing();
        }

        private void CreateSingleServing()
        {
            singleServing = new SingleServing()
            {
                Calories = 167,
                GramsProtein = 6.2,
                GramsCarbs = 5.4,
                GramsFat = 14.8,
                SizeInGrams = 28
            };
        }
    }
}

