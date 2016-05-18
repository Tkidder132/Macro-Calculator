namespace PersonalMealPlanner.UserControls
{
    partial class TotalsDisplay
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
            this.lblTotalsTitle = new System.Windows.Forms.Label();
            this.lblTotalGramsProtein = new System.Windows.Forms.Label();
            this.lblTotalGramsProteinTitle = new System.Windows.Forms.Label();
            this.lblTotalGramsCarbs = new System.Windows.Forms.Label();
            this.lblTotalGramsCarbsTitle = new System.Windows.Forms.Label();
            this.lblTotalGramsFatsTitle = new System.Windows.Forms.Label();
            this.lblTotalGramsCaloriesTitle = new System.Windows.Forms.Label();
            this.lblTotalGramsFats = new System.Windows.Forms.Label();
            this.lblTotalGramsCalories = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.Controls.Add(this.lblTotalsTitle, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTotalGramsProtein, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTotalGramsProteinTitle, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTotalGramsCarbs, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblTotalGramsCarbsTitle, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblTotalGramsFatsTitle, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblTotalGramsCaloriesTitle, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblTotalGramsFats, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblTotalGramsCalories, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(237, 267);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblTotalsTitle
            // 
            this.lblTotalsTitle.AutoSize = true;
            this.lblTotalsTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel1.SetColumnSpan(this.lblTotalsTitle, 2);
            this.lblTotalsTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalsTitle.Location = new System.Drawing.Point(3, 0);
            this.lblTotalsTitle.Name = "lblTotalsTitle";
            this.lblTotalsTitle.Size = new System.Drawing.Size(231, 53);
            this.lblTotalsTitle.TabIndex = 52;
            this.lblTotalsTitle.Text = "Totals";
            this.lblTotalsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalGramsProtein
            // 
            this.lblTotalGramsProtein.AutoSize = true;
            this.lblTotalGramsProtein.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalGramsProtein.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalGramsProtein.Location = new System.Drawing.Point(3, 53);
            this.lblTotalGramsProtein.Name = "lblTotalGramsProtein";
            this.lblTotalGramsProtein.Size = new System.Drawing.Size(53, 53);
            this.lblTotalGramsProtein.TabIndex = 53;
            this.lblTotalGramsProtein.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalGramsProteinTitle
            // 
            this.lblTotalGramsProteinTitle.AutoSize = true;
            this.lblTotalGramsProteinTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalGramsProteinTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalGramsProteinTitle.Location = new System.Drawing.Point(62, 53);
            this.lblTotalGramsProteinTitle.Name = "lblTotalGramsProteinTitle";
            this.lblTotalGramsProteinTitle.Size = new System.Drawing.Size(172, 53);
            this.lblTotalGramsProteinTitle.TabIndex = 54;
            this.lblTotalGramsProteinTitle.Text = "g. Protein";
            this.lblTotalGramsProteinTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalGramsCarbs
            // 
            this.lblTotalGramsCarbs.AutoSize = true;
            this.lblTotalGramsCarbs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalGramsCarbs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalGramsCarbs.Location = new System.Drawing.Point(3, 106);
            this.lblTotalGramsCarbs.Name = "lblTotalGramsCarbs";
            this.lblTotalGramsCarbs.Size = new System.Drawing.Size(53, 53);
            this.lblTotalGramsCarbs.TabIndex = 55;
            this.lblTotalGramsCarbs.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalGramsCarbsTitle
            // 
            this.lblTotalGramsCarbsTitle.AutoSize = true;
            this.lblTotalGramsCarbsTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalGramsCarbsTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalGramsCarbsTitle.Location = new System.Drawing.Point(62, 106);
            this.lblTotalGramsCarbsTitle.Name = "lblTotalGramsCarbsTitle";
            this.lblTotalGramsCarbsTitle.Size = new System.Drawing.Size(172, 53);
            this.lblTotalGramsCarbsTitle.TabIndex = 56;
            this.lblTotalGramsCarbsTitle.Text = "g. Carb";
            this.lblTotalGramsCarbsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalGramsFatsTitle
            // 
            this.lblTotalGramsFatsTitle.AutoSize = true;
            this.lblTotalGramsFatsTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalGramsFatsTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalGramsFatsTitle.Location = new System.Drawing.Point(62, 159);
            this.lblTotalGramsFatsTitle.Name = "lblTotalGramsFatsTitle";
            this.lblTotalGramsFatsTitle.Size = new System.Drawing.Size(172, 53);
            this.lblTotalGramsFatsTitle.TabIndex = 57;
            this.lblTotalGramsFatsTitle.Text = "g. Fat";
            this.lblTotalGramsFatsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalGramsCaloriesTitle
            // 
            this.lblTotalGramsCaloriesTitle.AutoSize = true;
            this.lblTotalGramsCaloriesTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalGramsCaloriesTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalGramsCaloriesTitle.Location = new System.Drawing.Point(62, 212);
            this.lblTotalGramsCaloriesTitle.Name = "lblTotalGramsCaloriesTitle";
            this.lblTotalGramsCaloriesTitle.Size = new System.Drawing.Size(172, 55);
            this.lblTotalGramsCaloriesTitle.TabIndex = 58;
            this.lblTotalGramsCaloriesTitle.Text = "Calories";
            this.lblTotalGramsCaloriesTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalGramsFats
            // 
            this.lblTotalGramsFats.AutoSize = true;
            this.lblTotalGramsFats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalGramsFats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalGramsFats.Location = new System.Drawing.Point(3, 159);
            this.lblTotalGramsFats.Name = "lblTotalGramsFats";
            this.lblTotalGramsFats.Size = new System.Drawing.Size(53, 53);
            this.lblTotalGramsFats.TabIndex = 59;
            this.lblTotalGramsFats.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalGramsCalories
            // 
            this.lblTotalGramsCalories.AutoSize = true;
            this.lblTotalGramsCalories.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalGramsCalories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalGramsCalories.Location = new System.Drawing.Point(3, 212);
            this.lblTotalGramsCalories.Name = "lblTotalGramsCalories";
            this.lblTotalGramsCalories.Size = new System.Drawing.Size(53, 55);
            this.lblTotalGramsCalories.TabIndex = 60;
            this.lblTotalGramsCalories.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TotalsDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "TotalsDisplay";
            this.Size = new System.Drawing.Size(237, 267);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblTotalsTitle;
        private System.Windows.Forms.Label lblTotalGramsProtein;
        private System.Windows.Forms.Label lblTotalGramsProteinTitle;
        private System.Windows.Forms.Label lblTotalGramsCarbs;
        private System.Windows.Forms.Label lblTotalGramsCarbsTitle;
        private System.Windows.Forms.Label lblTotalGramsFatsTitle;
        private System.Windows.Forms.Label lblTotalGramsCaloriesTitle;
        private System.Windows.Forms.Label lblTotalGramsFats;
        private System.Windows.Forms.Label lblTotalGramsCalories;
    }
}
