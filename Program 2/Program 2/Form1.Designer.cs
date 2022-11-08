namespace Program_2
{
    partial class Program2
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
            this.lblPeople = new System.Windows.Forms.Label();
            this.lblDistance = new System.Windows.Forms.Label();
            this.lblDeliveryDays = new System.Windows.Forms.Label();
            this.txtPeopleInput = new System.Windows.Forms.TextBox();
            this.txtMilesInput = new System.Windows.Forms.TextBox();
            this.txtDaysInput = new System.Windows.Forms.TextBox();
            this.lblCompanyA = new System.Windows.Forms.Label();
            this.lblCompanyB = new System.Windows.Forms.Label();
            this.lblCompanyC = new System.Windows.Forms.Label();
            this.lblCompanyACost = new System.Windows.Forms.Label();
            this.lblCompanyBCost = new System.Windows.Forms.Label();
            this.lblCompanyCCost = new System.Windows.Forms.Label();
            this.lblLowestCost = new System.Windows.Forms.Label();
            this.btnCalculateAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPeople
            // 
            this.lblPeople.AutoSize = true;
            this.lblPeople.Location = new System.Drawing.Point(96, 69);
            this.lblPeople.Name = "lblPeople";
            this.lblPeople.Size = new System.Drawing.Size(40, 13);
            this.lblPeople.TabIndex = 0;
            this.lblPeople.Text = "People";
            this.lblPeople.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDistance
            // 
            this.lblDistance.AutoSize = true;
            this.lblDistance.Location = new System.Drawing.Point(54, 119);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(82, 13);
            this.lblDistance.TabIndex = 1;
            this.lblDistance.Text = "Distance (Miles)";
            // 
            // lblDeliveryDays
            // 
            this.lblDeliveryDays.AutoSize = true;
            this.lblDeliveryDays.Location = new System.Drawing.Point(64, 171);
            this.lblDeliveryDays.Name = "lblDeliveryDays";
            this.lblDeliveryDays.Size = new System.Drawing.Size(72, 13);
            this.lblDeliveryDays.TabIndex = 2;
            this.lblDeliveryDays.Text = "Delivery Days";
            // 
            // txtPeopleInput
            // 
            this.txtPeopleInput.Location = new System.Drawing.Point(170, 69);
            this.txtPeopleInput.Name = "txtPeopleInput";
            this.txtPeopleInput.Size = new System.Drawing.Size(100, 20);
            this.txtPeopleInput.TabIndex = 3;
            // 
            // txtMilesInput
            // 
            this.txtMilesInput.Location = new System.Drawing.Point(170, 119);
            this.txtMilesInput.Name = "txtMilesInput";
            this.txtMilesInput.Size = new System.Drawing.Size(100, 20);
            this.txtMilesInput.TabIndex = 4;
            // 
            // txtDaysInput
            // 
            this.txtDaysInput.Location = new System.Drawing.Point(170, 168);
            this.txtDaysInput.Name = "txtDaysInput";
            this.txtDaysInput.Size = new System.Drawing.Size(100, 20);
            this.txtDaysInput.TabIndex = 5;
            // 
            // lblCompanyA
            // 
            this.lblCompanyA.AutoSize = true;
            this.lblCompanyA.Location = new System.Drawing.Point(308, 69);
            this.lblCompanyA.Name = "lblCompanyA";
            this.lblCompanyA.Size = new System.Drawing.Size(85, 13);
            this.lblCompanyA.TabIndex = 6;
            this.lblCompanyA.Text = "Company A Cost";
            // 
            // lblCompanyB
            // 
            this.lblCompanyB.AutoSize = true;
            this.lblCompanyB.Location = new System.Drawing.Point(308, 122);
            this.lblCompanyB.Name = "lblCompanyB";
            this.lblCompanyB.Size = new System.Drawing.Size(85, 13);
            this.lblCompanyB.TabIndex = 7;
            this.lblCompanyB.Text = "Company B Cost";
            // 
            // lblCompanyC
            // 
            this.lblCompanyC.AutoSize = true;
            this.lblCompanyC.Location = new System.Drawing.Point(308, 171);
            this.lblCompanyC.Name = "lblCompanyC";
            this.lblCompanyC.Size = new System.Drawing.Size(85, 13);
            this.lblCompanyC.TabIndex = 8;
            this.lblCompanyC.Text = "Company C Cost";
            // 
            // lblCompanyACost
            // 
            this.lblCompanyACost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCompanyACost.Location = new System.Drawing.Point(412, 66);
            this.lblCompanyACost.Name = "lblCompanyACost";
            this.lblCompanyACost.Size = new System.Drawing.Size(100, 23);
            this.lblCompanyACost.TabIndex = 9;
            this.lblCompanyACost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCompanyBCost
            // 
            this.lblCompanyBCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCompanyBCost.Location = new System.Drawing.Point(412, 117);
            this.lblCompanyBCost.Name = "lblCompanyBCost";
            this.lblCompanyBCost.Size = new System.Drawing.Size(100, 23);
            this.lblCompanyBCost.TabIndex = 10;
            this.lblCompanyBCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCompanyCCost
            // 
            this.lblCompanyCCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCompanyCCost.Location = new System.Drawing.Point(412, 165);
            this.lblCompanyCCost.Name = "lblCompanyCCost";
            this.lblCompanyCCost.Size = new System.Drawing.Size(100, 23);
            this.lblCompanyCCost.TabIndex = 11;
            this.lblCompanyCCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLowestCost
            // 
            this.lblLowestCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLowestCost.Location = new System.Drawing.Point(334, 214);
            this.lblLowestCost.Name = "lblLowestCost";
            this.lblLowestCost.Size = new System.Drawing.Size(162, 30);
            this.lblLowestCost.TabIndex = 12;
            this.lblLowestCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCalculateAll
            // 
            this.btnCalculateAll.Location = new System.Drawing.Point(99, 218);
            this.btnCalculateAll.Name = "btnCalculateAll";
            this.btnCalculateAll.Size = new System.Drawing.Size(119, 23);
            this.btnCalculateAll.TabIndex = 13;
            this.btnCalculateAll.Text = "Calculate Cost";
            this.btnCalculateAll.UseVisualStyleBackColor = true;
            this.btnCalculateAll.Click += new System.EventHandler(this.btnCalculateAll_Click);
            // 
            // Program2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 310);
            this.Controls.Add(this.btnCalculateAll);
            this.Controls.Add(this.lblLowestCost);
            this.Controls.Add(this.lblCompanyCCost);
            this.Controls.Add(this.lblCompanyBCost);
            this.Controls.Add(this.lblCompanyACost);
            this.Controls.Add(this.lblCompanyC);
            this.Controls.Add(this.lblCompanyB);
            this.Controls.Add(this.lblCompanyA);
            this.Controls.Add(this.txtDaysInput);
            this.Controls.Add(this.txtMilesInput);
            this.Controls.Add(this.txtPeopleInput);
            this.Controls.Add(this.lblDeliveryDays);
            this.Controls.Add(this.lblDistance);
            this.Controls.Add(this.lblPeople);
            this.Name = "Program2";
            this.Text = "Food Delivery Cost Calculation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPeople;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.Label lblDeliveryDays;
        private System.Windows.Forms.TextBox txtPeopleInput;
        private System.Windows.Forms.TextBox txtMilesInput;
        private System.Windows.Forms.TextBox txtDaysInput;
        private System.Windows.Forms.Label lblCompanyA;
        private System.Windows.Forms.Label lblCompanyB;
        private System.Windows.Forms.Label lblCompanyC;
        private System.Windows.Forms.Label lblCompanyACost;
        private System.Windows.Forms.Label lblCompanyBCost;
        private System.Windows.Forms.Label lblCompanyCCost;
        private System.Windows.Forms.Label lblLowestCost;
        private System.Windows.Forms.Button btnCalculateAll;
    }
}

