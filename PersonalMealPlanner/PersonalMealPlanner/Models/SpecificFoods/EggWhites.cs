namespace PersonalMealPlanner.Models.SpecificFoods
{
    class EggWhites : Food
    {
        public EggWhites()
        {
            Name = "Egg Whites";
            CreateSingleServing();
        }

        private void CreateSingleServing()
        {
            singleServing = new SingleServing()
            {
                Calories = 17,
                GramsProtein = 3.6,
                GramsCarbs = .2,
                GramsFat = .1,
                SizeInGrams = 33
            };
        }
    }
}
