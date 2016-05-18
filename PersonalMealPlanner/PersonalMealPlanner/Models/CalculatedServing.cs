using System;

namespace PersonalMealPlanner.Models
{
    public class CalculatedServing : NutritionValues
    {
        public CalculatedServing()
        { 
            SizeInGrams = 0;
            GramsProtein = 0;
            GramsCarbs = 0;
            GramsFat = 0;
            Calories = 0;
        }

        public double ServingSizeRatio = 0;

        public void IncreaseServingByAmount(double amount)
        {
            ChangeServingByAmount(amount);
        }

        public void DecreaseServingByAmount(double amount)
        {
            ChangeServingByAmount(NegativeAmount(amount));
        }

        private double NegativeAmount(double amount)
        {
            return -Math.Abs(amount);
        }

        private void ChangeServingByAmount(double amount)
        {
            SizeInGrams += amount;
        }

        public void CalculateNutritionValuesFromSingleServing(SingleServing singleServing)
        {
            SetServingSizeRatio(singleServing.SizeInGrams);
            CalculateProtein(singleServing.GramsProtein);
            CalculateCarbs(singleServing.GramsCarbs);
            CalculateFat(singleServing.GramsFat);
            CalculateCalories(singleServing.Calories);
        }

        private void SetServingSizeRatio(double servingSize)
        {
            ServingSizeRatio = SizeInGrams == 0 ? 0 : (SizeInGrams / servingSize);
        }

        private void CalculateProtein(double gramsProtein)
        {
            GramsProtein = ServingSizeRatio * gramsProtein;
        }

        private void CalculateCarbs(double gramsCarbs)
        {
            GramsCarbs = ServingSizeRatio * gramsCarbs;
        }

        private void CalculateFat(double gramsFat)
        {
            GramsFat = ServingSizeRatio * gramsFat;
        }

        private void CalculateCalories(double baseCalories)
        {
            Calories = ServingSizeRatio * baseCalories;
        }
    }
}
