namespace Lab2
{
    partial class Lab2
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblEntPriceofMeal = new System.Windows.Forms.Label();
            this.lblPercent15 = new System.Windows.Forms.Label();
            this.lblPercent18 = new System.Windows.Forms.Label();
            this.lblPercent20 = new System.Windows.Forms.Label();
            this.Output15Percent = new System.Windows.Forms.Label();
            this.Output18Percent = new System.Windows.Forms.Label();
            this.Output20Percent = new System.Windows.Forms.Label();
            this.btnCalculator = new System.Windows.Forms.Button();
            this.MealPriceInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblEntPriceofMeal
            // 
            this.lblEntPriceofMeal.Location = new System.Drawing.Point(55, 30);
            this.lblEntPriceofMeal.Name = "lblEntPriceofMeal";
            this.lblEntPriceofMeal.Size = new System.Drawing.Size(105, 25);
            this.lblEntPriceofMeal.TabIndex = 0;
            this.lblEntPriceofMeal.Text = "Enter price of meal:";
            this.lblEntPriceofMeal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPercent15
            // 
            this.lblPercent15.Location = new System.Drawing.Point(89, 64);
            this.lblPercent15.Name = "lblPercent15";
            this.lblPercent15.Size = new System.Drawing.Size(71, 28);
            this.lblPercent15.TabIndex = 1;
            this.lblPercent15.Text = "15 %";
            this.lblPercent15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPercent18
            // 
            this.lblPercent18.Location = new System.Drawing.Point(107, 100);
            this.lblPercent18.Name = "lblPercent18";
            this.lblPercent18.Size = new System.Drawing.Size(53, 29);
            this.lblPercent18.TabIndex = 2;
            this.lblPercent18.Text = "18 %";
            this.lblPercent18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPercent20
            // 
            this.lblPercent20.Location = new System.Drawing.Point(125, 143);
            this.lblPercent20.Name = "lblPercent20";
            this.lblPercent20.Size = new System.Drawing.Size(35, 13);
            this.lblPercent20.TabIndex = 3;
            this.lblPercent20.Text = "20 %";
            this.lblPercent20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Output15Percent
            // 
            this.Output15Percent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Output15Percent.Location = new System.Drawing.Point(167, 72);
            this.Output15Percent.Name = "Output15Percent";
            this.Output15Percent.Size = new System.Drawing.Size(103, 20);
            this.Output15Percent.TabIndex = 4;
            this.Output15Percent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Output18Percent
            // 
            this.Output18Percent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Output18Percent.Location = new System.Drawing.Point(167, 108);
            this.Output18Percent.Name = "Output18Percent";
            this.Output18Percent.Size = new System.Drawing.Size(103, 21);
            this.Output18Percent.TabIndex = 5;
            // 
            // Output20Percent
            // 
            this.Output20Percent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Output20Percent.Location = new System.Drawing.Point(167, 143);
            this.Output20Percent.Name = "Output20Percent";
            this.Output20Percent.Size = new System.Drawing.Size(103, 20);
            this.Output20Percent.TabIndex = 6;
            this.Output20Percent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCalculator
            // 
            this.btnCalculator.Location = new System.Drawing.Point(119, 179);
            this.btnCalculator.Name = "btnCalculator";
            this.btnCalculator.Size = new System.Drawing.Size(91, 27);
            this.btnCalculator.TabIndex = 7;
            this.btnCalculator.Text = "Calculate Cost";
            this.btnCalculator.UseVisualStyleBackColor = true;
            this.btnCalculator.Click += new System.EventHandler(this.btnCalculator_Click);
            // 
            // MealPriceInput
            // 
            this.MealPriceInput.Location = new System.Drawing.Point(166, 33);
            this.MealPriceInput.Name = "MealPriceInput";
            this.MealPriceInput.Size = new System.Drawing.Size(104, 20);
            this.MealPriceInput.TabIndex = 8;
            // 
            // Lab2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 236);
            this.Controls.Add(this.MealPriceInput);
            this.Controls.Add(this.btnCalculator);
            this.Controls.Add(this.Output20Percent);
            this.Controls.Add(this.Output18Percent);
            this.Controls.Add(this.Output15Percent);
            this.Controls.Add(this.lblPercent20);
            this.Controls.Add(this.lblPercent18);
            this.Controls.Add(this.lblPercent15);
            this.Controls.Add(this.lblEntPriceofMeal);
            this.Name = "Lab2";
            this.Text = "Lab 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEntPriceofMeal;
        private System.Windows.Forms.Label lblPercent15;
        private System.Windows.Forms.Label lblPercent18;
        private System.Windows.Forms.Label lblPercent20;
        private System.Windows.Forms.Label Output15Percent;
        private System.Windows.Forms.Label Output18Percent;
        private System.Windows.Forms.Label Output20Percent;
        private System.Windows.Forms.Button btnCalculator;
        private System.Windows.Forms.TextBox MealPriceInput;
    }
}

