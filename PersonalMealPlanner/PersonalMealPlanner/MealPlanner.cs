using PersonalMealPlanner.Models.SpecificFoods;
using PersonalMealPlanner.UserControls;
using System.Windows.Forms;
using System.Collections.Generic;
using PersonalMealPlanner.Models;

namespace PersonalMealPlanner
{
    public partial class MealPlanner : Form
    {
        List<ucFoodDisplay> foodDisplays = new List<ucFoodDisplay>();
        NutritionValues totalValues = new NutritionValues();
        TotalsDisplay totalsDisplay = new TotalsDisplay();

        public MealPlanner()
        {
            InitializeComponent();
            CreateAndAddAlmondsDisplay();
            CreateAndAddChickenDisplay();
            CreateAndAddBroccoliDisplay();
            CreateAndAddBrownRiceDisplay();
            CreateAndAddEggWhitesDisplay();
            CreateAndAddEggWholeDisplay();
            CreateAndAddTilapiaDisplay();
            CreateAndAddTotalsDisplay();
        }

        private void CreateAndAddAlmondsDisplay()
        {
            AddFoodDisplayToListAndScreen(CreateGenericFoodDisplay(new Almond()), panel8);
        }

        private void CreateAndAddChickenDisplay()
        {
            AddFoodDisplayToListAndScreen(CreateGenericFoodDisplay(new Chicken()), panel1);
        }

        private void CreateAndAddBroccoliDisplay()
        {
            AddFoodDisplayToListAndScreen(CreateGenericFoodDisplay(new Broccoli()), panel2);
        }

        private void CreateAndAddBrownRiceDisplay()
        {
            AddFoodDisplayToListAndScreen(CreateGenericFoodDisplay(new BrownRice()), panel3);
        }

        private void CreateAndAddEggWhitesDisplay()
        {
            AddFoodDisplayToListAndScreen(CreateGenericFoodDisplay(new EggWhites()), panel4);
        }

        private void CreateAndAddEggWholeDisplay()
        {
            AddFoodDisplayToListAndScreen(CreateGenericFoodDisplay(new EggWhole()), panel7);
        }

        private void CreateAndAddTilapiaDisplay()
        {
            AddFoodDisplayToListAndScreen(CreateGenericFoodDisplay(new Tilapia()), panel5);
        }

        private ucFoodDisplay CreateGenericFoodDisplay(Food food)
        {
            return new ucFoodDisplay(food, this);
        }
        
        private void AddFoodDisplayToListAndScreen(ucFoodDisplay userControlFoodDisplay, Panel panelPlacement)
        {
            foodDisplays.Add(userControlFoodDisplay);
            AddUserDisplayToScreen(userControlFoodDisplay, panelPlacement);
        }

        private void AddUserDisplayToScreen(UserControl userControlDisplay, Panel panelPlacement)
        {
            userControlDisplay.Dock = DockStyle.Fill;
            panelPlacement.Controls.Add(userControlDisplay);
        }

        private void CreateAndAddTotalsDisplay()
        {
            AddUserDisplayToScreen(totalsDisplay, panel6);
        }

        public void UpdateTotals()
        {
            ResetTotalValues();
            CalculateTotalNutritionValues();
            totalsDisplay.UpdateAndDisplayTotals(totalValues);
        }

        private void CalculateTotalNutritionValues()
        {
            SingleServing tempSingleServingValues = new SingleServing();

            foreach (ucFoodDisplay foodDisplay in foodDisplays)
            {
                tempSingleServingValues = foodDisplay.GetNutritionValues();
                double ServingSize = foodDisplay.GetServingAmount();

                totalValues.Calories += (tempSingleServingValues.Calories * ServingSize);
                totalValues.GramsCarbs += (tempSingleServingValues.GramsCarbs * ServingSize);
                totalValues.GramsFat += (tempSingleServingValues.GramsFat * ServingSize);
                totalValues.GramsProtein += (tempSingleServingValues.GramsProtein * ServingSize);
            }
        }

        private void ResetTotalValues()
        {
            totalValues.Calories = 0;
            totalValues.GramsCarbs = 0;
            totalValues.GramsFat = 0;
            totalValues.GramsProtein = 0;
            totalValues.SizeInGrams = 0;
        }
    }
}
