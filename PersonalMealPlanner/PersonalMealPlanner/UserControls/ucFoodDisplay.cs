using PersonalMealPlanner.Models;
using System;
using System.Windows.Forms;

namespace PersonalMealPlanner.UserControls
{
    public partial class ucFoodDisplay : UserControl
    {
        private Food food;
        private MealPlanner mainForm;
        private bool InitialSetup = true;
        private bool ManuallyEditing = false;

        public ucFoodDisplay(Food _food, MealPlanner _mainForm)
        {
            InitializeComponent();
            food = _food;
            mainForm = _mainForm;
            DisplayValues();
            InitialSetup = false;
        }

        private void BtnIncreaseFoodServingClick(object sender, EventArgs e)
        {
            food.IncreaseServingByAmountAndRecalculateNutrition(GetFoodServingsFromTextBox(), .05);
            DisplayValuesAndUpdateTotals();
        }

        private void BtnDecreaseFoodServingClick(object sender, EventArgs e)
        {
            if (DecreasingServingCausesNegativeValue())
            {
                food.SetServingAmountAndRecalculateNutrition(0.0);
            }
            else
            {
                food.DecreaseServingByAmountAndRecalculateNutrition(GetFoodServingsFromTextBox(), .05);
            }
            DisplayValuesAndUpdateTotals();
        }

        private bool DecreasingServingCausesNegativeValue()
        {
            return GetFoodServingsFromTextBox() - .05 < 0;
        }

        private void DisplayValuesAndUpdateTotals()
        {
            DisplayValues();
            mainForm.UpdateTotals();
        }

        private void DisplayValues()
        {
            SetLabelText(lblFoodGrams, food.calculatedValues.SizeInGrams.ToString());
            SetLabelText(lblFoodTitle, "g. " + food.Name.ToString());

            ManuallyEditTextBox();

            SetLabelText(lblFoodGramsProtein, food.calculatedValues.GramsProtein.ToString());
            SetLabelText(lblFoodGramsCarbs, food.calculatedValues.GramsCarbs.ToString());
            SetLabelText(lblFoodGramsFat, food.calculatedValues.GramsFat.ToString());
            SetLabelText(lblFoodCalories, food.calculatedValues.Calories.ToString());
        }

        private void ManuallyEditTextBox()
        {
            ManuallyEditing = true;
            SetTextBoxText(txtbFoodServings, food.calculatedValues.ServingSizeRatio.ToString());
            ManuallyEditing = false;
        }

        private void SetTextBoxText(TextBox textbox, string text)
        {
            textbox.Text = text;
        }

        private void SetLabelText(Label label, string text)
        {
            label.Text = text;
        }

        private void TxtbFoodServingsTextChanged(object sender, EventArgs e)
        {
            if (!InitialSetup)
            {
                food.SetServingAmountAndRecalculateNutrition(GetFoodServingsFromTextBox());
                DisplayValuesAndUpdateTotals();
            }
        }

        private double GetFoodServingsFromTextBox()
        {
            double foodServings = 0.0;
            return double.TryParse(txtbFoodServings.Text, out foodServings) ? foodServings : 0.0;
        }

        public SingleServing GetNutritionValues()
        {
            return food.singleServing;
        }

        public double GetServingAmount()
        {
            return GetFoodServingsFromTextBox();
        }
    }
}
