namespace PersonalMealPlanner.Models.SpecificFoods
{
    public class BrownRice : Food
    {
        public BrownRice()
        {
            Name = "Brown Rice";
            CreateSingleServing();
        }

        private void CreateSingleServing()
        {
            singleServing = new SingleServing()
            {
                Calories = 150,
                GramsProtein = 3,
                GramsCarbs = 34,
                GramsFat = 1.5,
                SizeInGrams = 43
            };
        }
    }
}
