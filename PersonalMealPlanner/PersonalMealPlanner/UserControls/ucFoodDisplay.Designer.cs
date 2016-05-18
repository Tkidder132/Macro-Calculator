namespace PersonalMealPlanner.UserControls
{
    partial class ucFoodDisplay
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tlpFoodServingButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnDecreaseFoodServing = new System.Windows.Forms.Button();
            this.btnIncreaseFoodServing = new System.Windows.Forms.Button();
            this.lblFoodGrams = new System.Windows.Forms.Label();
            this.lblFoodTitle = new System.Windows.Forms.Label();
            this.lblFoodGramsProtein = new System.Windows.Forms.Label();
            this.lblFoodGramsCarbs = new System.Windows.Forms.Label();
            this.lblFoodGramsFat = new System.Windows.Forms.Label();
            this.lblFoodCalories = new System.Windows.Forms.Label();
            this.lblFoodGramsProteinTitle = new System.Windows.Forms.Label();
            this.lblFoodGramsCarbsTitle = new System.Windows.Forms.Label();
            this.lblFoodGramsFatTitle = new System.Windows.Forms.Label();
            this.lblFoodGramsCaloriesTitle = new System.Windows.Forms.Label();
            this.lblServingsTitle = new System.Windows.Forms.Label();
            this.txtbFoodServings = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tlpFoodServingButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tlpFoodServingButtons, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblFoodGrams, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblFoodTitle, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblFoodGramsProtein, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblFoodGramsCarbs, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblFoodGramsFat, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblFoodCalories, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblFoodGramsProteinTitle, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblFoodGramsCarbsTitle, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblFoodGramsFatTitle, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblFoodGramsCaloriesTitle, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblServingsTitle, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtbFoodServings, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(240, 219);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tlpFoodServingButtons
            // 
            this.tlpFoodServingButtons.ColumnCount = 1;
            this.tlpFoodServingButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFoodServingButtons.Controls.Add(this.btnDecreaseFoodServing, 0, 1);
            this.tlpFoodServingButtons.Controls.Add(this.btnIncreaseFoodServing, 0, 0);
            this.tlpFoodServingButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpFoodServingButtons.Location = new System.Drawing.Point(3, 3);
            this.tlpFoodServingButtons.Name = "tlpFoodServingButtons";
            this.tlpFoodServingButtons.RowCount = 2;
            this.tableLayoutPanel1.SetRowSpan(this.tlpFoodServingButtons, 2);
            this.tlpFoodServingButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpFoodServingButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpFoodServingButtons.Size = new System.Drawing.Size(54, 66);
            this.tlpFoodServingButtons.TabIndex = 24;
            // 
            // btnDecreaseFoodServing
            // 
            this.btnDecreaseFoodServing.AutoSize = true;
            this.btnDecreaseFoodServing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDecreaseFoodServing.Location = new System.Drawing.Point(1, 34);
            this.btnDecreaseFoodServing.Margin = new System.Windows.Forms.Padding(1);
            this.btnDecreaseFoodServing.Name = "btnDecreaseFoodServing";
            this.btnDecreaseFoodServing.Size = new System.Drawing.Size(52, 31);
            this.btnDecreaseFoodServing.TabIndex = 1;
            this.btnDecreaseFoodServing.Text = "↓";
            this.btnDecreaseFoodServing.UseVisualStyleBackColor = true;
            this.btnDecreaseFoodServing.Click += new System.EventHandler(this.BtnDecreaseFoodServingClick);
            // 
            // btnIncreaseFoodServing
            // 
            this.btnIncreaseFoodServing.AutoSize = true;
            this.btnIncreaseFoodServing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnIncreaseFoodServing.Location = new System.Drawing.Point(1, 1);
            this.btnIncreaseFoodServing.Margin = new System.Windows.Forms.Padding(1);
            this.btnIncreaseFoodServing.Name = "btnIncreaseFoodServing";
            this.btnIncreaseFoodServing.Size = new System.Drawing.Size(52, 31);
            this.btnIncreaseFoodServing.TabIndex = 0;
            this.btnIncreaseFoodServing.Text = "↑";
            this.btnIncreaseFoodServing.UseVisualStyleBackColor = true;
            this.btnIncreaseFoodServing.Click += new System.EventHandler(this.BtnIncreaseFoodServingClick);
            // 
            // lblFoodGrams
            // 
            this.lblFoodGrams.AutoSize = true;
            this.lblFoodGrams.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFoodGrams.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFoodGrams.Location = new System.Drawing.Point(63, 0);
            this.lblFoodGrams.Name = "lblFoodGrams";
            this.lblFoodGrams.Size = new System.Drawing.Size(54, 36);
            this.lblFoodGrams.TabIndex = 25;
            this.lblFoodGrams.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFoodTitle
            // 
            this.lblFoodTitle.AutoSize = true;
            this.lblFoodTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFoodTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFoodTitle.Location = new System.Drawing.Point(123, 0);
            this.lblFoodTitle.Name = "lblFoodTitle";
            this.lblFoodTitle.Size = new System.Drawing.Size(114, 36);
            this.lblFoodTitle.TabIndex = 26;
            this.lblFoodTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFoodGramsProtein
            // 
            this.lblFoodGramsProtein.AutoSize = true;
            this.lblFoodGramsProtein.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFoodGramsProtein.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFoodGramsProtein.Location = new System.Drawing.Point(3, 72);
            this.lblFoodGramsProtein.Name = "lblFoodGramsProtein";
            this.lblFoodGramsProtein.Size = new System.Drawing.Size(54, 36);
            this.lblFoodGramsProtein.TabIndex = 27;
            this.lblFoodGramsProtein.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFoodGramsCarbs
            // 
            this.lblFoodGramsCarbs.AutoSize = true;
            this.lblFoodGramsCarbs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFoodGramsCarbs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFoodGramsCarbs.Location = new System.Drawing.Point(3, 108);
            this.lblFoodGramsCarbs.Name = "lblFoodGramsCarbs";
            this.lblFoodGramsCarbs.Size = new System.Drawing.Size(54, 36);
            this.lblFoodGramsCarbs.TabIndex = 28;
            this.lblFoodGramsCarbs.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFoodGramsFat
            // 
            this.lblFoodGramsFat.AutoSize = true;
            this.lblFoodGramsFat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFoodGramsFat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFoodGramsFat.Location = new System.Drawing.Point(3, 144);
            this.lblFoodGramsFat.Name = "lblFoodGramsFat";
            this.lblFoodGramsFat.Size = new System.Drawing.Size(54, 36);
            this.lblFoodGramsFat.TabIndex = 29;
            this.lblFoodGramsFat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFoodCalories
            // 
            this.lblFoodCalories.AutoSize = true;
            this.lblFoodCalories.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFoodCalories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFoodCalories.Location = new System.Drawing.Point(3, 180);
            this.lblFoodCalories.Name = "lblFoodCalories";
            this.lblFoodCalories.Size = new System.Drawing.Size(54, 39);
            this.lblFoodCalories.TabIndex = 30;
            this.lblFoodCalories.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFoodGramsProteinTitle
            // 
            this.lblFoodGramsProteinTitle.AutoSize = true;
            this.lblFoodGramsProteinTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel1.SetColumnSpan(this.lblFoodGramsProteinTitle, 2);
            this.lblFoodGramsProteinTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFoodGramsProteinTitle.Location = new System.Drawing.Point(63, 72);
            this.lblFoodGramsProteinTitle.Name = "lblFoodGramsProteinTitle";
            this.lblFoodGramsProteinTitle.Size = new System.Drawing.Size(174, 36);
            this.lblFoodGramsProteinTitle.TabIndex = 31;
            this.lblFoodGramsProteinTitle.Text = "g. Protein";
            this.lblFoodGramsProteinTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFoodGramsCarbsTitle
            // 
            this.lblFoodGramsCarbsTitle.AutoSize = true;
            this.lblFoodGramsCarbsTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel1.SetColumnSpan(this.lblFoodGramsCarbsTitle, 2);
            this.lblFoodGramsCarbsTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFoodGramsCarbsTitle.Location = new System.Drawing.Point(63, 108);
            this.lblFoodGramsCarbsTitle.Name = "lblFoodGramsCarbsTitle";
            this.lblFoodGramsCarbsTitle.Size = new System.Drawing.Size(174, 36);
            this.lblFoodGramsCarbsTitle.TabIndex = 32;
            this.lblFoodGramsCarbsTitle.Text = "g. Carb";
            this.lblFoodGramsCarbsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFoodGramsFatTitle
            // 
            this.lblFoodGramsFatTitle.AutoSize = true;
            this.lblFoodGramsFatTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel1.SetColumnSpan(this.lblFoodGramsFatTitle, 2);
            this.lblFoodGramsFatTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFoodGramsFatTitle.Location = new System.Drawing.Point(63, 144);
            this.lblFoodGramsFatTitle.Name = "lblFoodGramsFatTitle";
            this.lblFoodGramsFatTitle.Size = new System.Drawing.Size(174, 36);
            this.lblFoodGramsFatTitle.TabIndex = 33;
            this.lblFoodGramsFatTitle.Text = "g. Fat";
            this.lblFoodGramsFatTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFoodGramsCaloriesTitle
            // 
            this.lblFoodGramsCaloriesTitle.AutoSize = true;
            this.lblFoodGramsCaloriesTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel1.SetColumnSpan(this.lblFoodGramsCaloriesTitle, 2);
            this.lblFoodGramsCaloriesTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFoodGramsCaloriesTitle.Location = new System.Drawing.Point(63, 180);
            this.lblFoodGramsCaloriesTitle.Name = "lblFoodGramsCaloriesTitle";
            this.lblFoodGramsCaloriesTitle.Size = new System.Drawing.Size(174, 39);
            this.lblFoodGramsCaloriesTitle.TabIndex = 34;
            this.lblFoodGramsCaloriesTitle.Text = "Calories";
            this.lblFoodGramsCaloriesTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblServingsTitle
            // 
            this.lblServingsTitle.AutoSize = true;
            this.lblServingsTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblServingsTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblServingsTitle.Location = new System.Drawing.Point(123, 36);
            this.lblServingsTitle.Name = "lblServingsTitle";
            this.lblServingsTitle.Size = new System.Drawing.Size(114, 36);
            this.lblServingsTitle.TabIndex = 35;
            this.lblServingsTitle.Text = "Servings";
            this.lblServingsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtbFoodServings
            // 
            this.txtbFoodServings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbFoodServings.Location = new System.Drawing.Point(63, 39);
            this.txtbFoodServings.Name = "txtbFoodServings";
            this.txtbFoodServings.Size = new System.Drawing.Size(54, 20);
            this.txtbFoodServings.TabIndex = 36;
            this.txtbFoodServings.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtbFoodServings.TextChanged += new System.EventHandler(this.TxtbFoodServingsTextChanged);
            // 
            // ucFoodDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucFoodDisplay";
            this.Size = new System.Drawing.Size(240, 219);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tlpFoodServingButtons.ResumeLayout(false);
            this.tlpFoodServingButtons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tlpFoodServingButtons;
        private System.Windows.Forms.Button btnDecreaseFoodServing;
        private System.Windows.Forms.Button btnIncreaseFoodServing;
        private System.Windows.Forms.Label lblFoodGrams;
        private System.Windows.Forms.Label lblFoodTitle;
        private System.Windows.Forms.Label lblFoodGramsProtein;
        private System.Windows.Forms.Label lblFoodGramsCarbs;
        private System.Windows.Forms.Label lblFoodGramsFat;
        private System.Windows.Forms.Label lblFoodCalories;
        private System.Windows.Forms.Label lblFoodGramsProteinTitle;
        private System.Windows.Forms.Label lblFoodGramsCarbsTitle;
        private System.Windows.Forms.Label lblFoodGramsFatTitle;
        private System.Windows.Forms.Label lblFoodGramsCaloriesTitle;
        private System.Windows.Forms.Label lblServingsTitle;
        private System.Windows.Forms.TextBox txtbFoodServings;
    }
}
