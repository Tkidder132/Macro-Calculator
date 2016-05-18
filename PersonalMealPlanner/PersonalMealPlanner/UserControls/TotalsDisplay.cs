using PersonalMealPlanner.Models;
using System.Windows.Forms;

namespace PersonalMealPlanner.UserControls
{
    public partial class TotalsDisplay : UserControl
    {
        NutritionValues totalsValues;
        public TotalsDisplay()
        {
            InitializeComponent();
            InitializeTotalsValues();
        }

        private void InitializeTotalsValues()
        {
            totalsValues = new NutritionValues();
        }

        public void UpdateAndDisplayTotals(NutritionValues updatedValues)
        {
            UpdateTotals(updatedValues);
            DisplayTotals();
        }

        private void UpdateTotals(NutritionValues updatedValues)
        {
            totalsValues = updatedValues;
        }

        private void DisplayTotals()
        {
            UpdateLabelText(lblTotalGramsCalories, totalsValues.Calories.ToString());
            UpdateLabelText(lblTotalGramsCarbs, totalsValues.GramsCarbs.ToString());
            UpdateLabelText(lblTotalGramsFats, totalsValues.GramsFat.ToString());
            UpdateLabelText(lblTotalGramsProtein, totalsValues.GramsProtein.ToString());
        }

        private void UpdateLabelText(Label label, string text)
        {
            label.Text = text;
        }
    }
}
