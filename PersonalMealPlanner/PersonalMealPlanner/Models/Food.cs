namespace PersonalMealPlanner.Models
{
    public class Food
    {
        public string Name { get; set; }

        public SingleServing singleServing;
        public CalculatedServing calculatedValues = new CalculatedServing();

        public void IncreaseServingByAmountAndRecalculateNutrition(double servingSize, double amount)
        {
            SetServingAmountAndRecalculateNutrition(servingSize + amount);
            CalculateNutritionValues();
        }

        public void DecreaseServingByAmountAndRecalculateNutrition(double servingSize, double amount)
        {
            SetServingAmountAndRecalculateNutrition(servingSize - amount);
            CalculateNutritionValues();
        }

        public void SetServingAmountAndRecalculateNutrition(double servingSize)
        {
            CalculateGramsFromServingSize(servingSize);
            CalculateNutritionValues();
        }

        private void CalculateGramsFromServingSize(double servingSize)
        {
            calculatedValues.SizeInGrams = servingSize * singleServing.SizeInGrams;
        }

        private void IncreaseServingByAmount(double amount)
        {
            calculatedValues.IncreaseServingByAmount(amount);
        }

        private void DecreaseServingByAmount(double amount)
        {
            calculatedValues.DecreaseServingByAmount(amount);
        }

        public void CalculateNutritionValues()
        {
            calculatedValues.CalculateNutritionValuesFromSingleServing(singleServing);
        }
    }
}
