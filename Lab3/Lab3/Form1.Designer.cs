namespace Lab3
{
    partial class Lab3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab3));
            this.lblRadiusRequest = new System.Windows.Forms.Label();
            this.pictureSPhere1 = new System.Windows.Forms.PictureBox();
            this.lblRadiusInput = new System.Windows.Forms.MaskedTextBox();
            this.lblDiameterEquation = new System.Windows.Forms.Label();
            this.lblSurfaceAreaEquation = new System.Windows.Forms.Label();
            this.lblVolumeEquation = new System.Windows.Forms.Label();
            this.lblDiameterOutput = new System.Windows.Forms.Label();
            this.lblSurfaceAreaOutput = new System.Windows.Forms.Label();
            this.lblVolumeOutput = new System.Windows.Forms.Label();
            this.pictureSphere2 = new System.Windows.Forms.PictureBox();
            this.btnCalculateEquations = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSPhere1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSphere2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRadiusRequest
            // 
            this.lblRadiusRequest.Location = new System.Drawing.Point(168, 86);
            this.lblRadiusRequest.Name = "lblRadiusRequest";
            this.lblRadiusRequest.Size = new System.Drawing.Size(100, 23);
            this.lblRadiusRequest.TabIndex = 0;
            this.lblRadiusRequest.Text = "Radius of sphere: ";
            // 
            // pictureSPhere1
            // 
            this.pictureSPhere1.Image = ((System.Drawing.Image)(resources.GetObject("pictureSPhere1.Image")));
            this.pictureSPhere1.Location = new System.Drawing.Point(12, 34);
            this.pictureSPhere1.Name = "pictureSPhere1";
            this.pictureSPhere1.Size = new System.Drawing.Size(150, 150);
            this.pictureSPhere1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureSPhere1.TabIndex = 1;
            this.pictureSPhere1.TabStop = false;
            // 
            // lblRadiusInput
            // 
            this.lblRadiusInput.Location = new System.Drawing.Point(272, 83);
            this.lblRadiusInput.Name = "lblRadiusInput";
            this.lblRadiusInput.Size = new System.Drawing.Size(100, 20);
            this.lblRadiusInput.TabIndex = 2;
            // 
            // lblDiameterEquation
            // 
            this.lblDiameterEquation.AutoSize = true;
            this.lblDiameterEquation.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDiameterEquation.Location = new System.Drawing.Point(39, 214);
            this.lblDiameterEquation.Name = "lblDiameterEquation";
            this.lblDiameterEquation.Size = new System.Drawing.Size(49, 13);
            this.lblDiameterEquation.TabIndex = 3;
            this.lblDiameterEquation.Text = "Diameter";
            // 
            // lblSurfaceAreaEquation
            // 
            this.lblSurfaceAreaEquation.AutoSize = true;
            this.lblSurfaceAreaEquation.Location = new System.Drawing.Point(19, 251);
            this.lblSurfaceAreaEquation.Name = "lblSurfaceAreaEquation";
            this.lblSurfaceAreaEquation.Size = new System.Drawing.Size(69, 13);
            this.lblSurfaceAreaEquation.TabIndex = 4;
            this.lblSurfaceAreaEquation.Text = "Surface Area";
            // 
            // lblVolumeEquation
            // 
            this.lblVolumeEquation.AutoSize = true;
            this.lblVolumeEquation.Location = new System.Drawing.Point(46, 286);
            this.lblVolumeEquation.Name = "lblVolumeEquation";
            this.lblVolumeEquation.Size = new System.Drawing.Size(42, 13);
            this.lblVolumeEquation.TabIndex = 5;
            this.lblVolumeEquation.Text = "Volume";
            // 
            // lblDiameterOutput
            // 
            this.lblDiameterOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDiameterOutput.Location = new System.Drawing.Point(106, 214);
            this.lblDiameterOutput.Name = "lblDiameterOutput";
            this.lblDiameterOutput.Size = new System.Drawing.Size(84, 23);
            this.lblDiameterOutput.TabIndex = 6;
            // 
            // lblSurfaceAreaOutput
            // 
            this.lblSurfaceAreaOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSurfaceAreaOutput.Location = new System.Drawing.Point(106, 251);
            this.lblSurfaceAreaOutput.Name = "lblSurfaceAreaOutput";
            this.lblSurfaceAreaOutput.Size = new System.Drawing.Size(84, 23);
            this.lblSurfaceAreaOutput.TabIndex = 7;
            // 
            // lblVolumeOutput
            // 
            this.lblVolumeOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblVolumeOutput.Location = new System.Drawing.Point(106, 286);
            this.lblVolumeOutput.Name = "lblVolumeOutput";
            this.lblVolumeOutput.Size = new System.Drawing.Size(84, 23);
            this.lblVolumeOutput.TabIndex = 8;
            // 
            // pictureSphere2
            // 
            this.pictureSphere2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureSphere2.BackgroundImage")));
            this.pictureSphere2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureSphere2.ErrorImage")));
            this.pictureSphere2.Image = ((System.Drawing.Image)(resources.GetObject("pictureSphere2.Image")));
            this.pictureSphere2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureSphere2.InitialImage")));
            this.pictureSphere2.Location = new System.Drawing.Point(206, 199);
            this.pictureSphere2.Name = "pictureSphere2";
            this.pictureSphere2.Size = new System.Drawing.Size(150, 150);
            this.pictureSphere2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureSphere2.TabIndex = 9;
            this.pictureSphere2.TabStop = false;
            // 
            // btnCalculateEquations
            // 
            this.btnCalculateEquations.Location = new System.Drawing.Point(281, 119);
            this.btnCalculateEquations.Name = "btnCalculateEquations";
            this.btnCalculateEquations.Size = new System.Drawing.Size(75, 23);
            this.btnCalculateEquations.TabIndex = 10;
            this.btnCalculateEquations.Text = "Calculate";
            this.btnCalculateEquations.UseVisualStyleBackColor = true;
            this.btnCalculateEquations.Click += new System.EventHandler(this.btnCalculateEquations_Click);
            // 
            // Lab3
            // 
            this.AcceptButton = this.btnCalculateEquations;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.btnCalculateEquations);
            this.Controls.Add(this.pictureSphere2);
            this.Controls.Add(this.lblVolumeOutput);
            this.Controls.Add(this.lblSurfaceAreaOutput);
            this.Controls.Add(this.lblDiameterOutput);
            this.Controls.Add(this.lblVolumeEquation);
            this.Controls.Add(this.lblSurfaceAreaEquation);
            this.Controls.Add(this.lblDiameterEquation);
            this.Controls.Add(this.lblRadiusInput);
            this.Controls.Add(this.pictureSPhere1);
            this.Controls.Add(this.lblRadiusRequest);
            this.Name = "Lab3";
            this.Text = "Lab 3";
            ((System.ComponentModel.ISupportInitialize)(this.pictureSPhere1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSphere2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRadiusRequest;
        private System.Windows.Forms.PictureBox pictureSPhere1;
        private System.Windows.Forms.MaskedTextBox lblRadiusInput;
        private System.Windows.Forms.Label lblDiameterEquation;
        private System.Windows.Forms.Label lblSurfaceAreaEquation;
        private System.Windows.Forms.Label lblVolumeEquation;
        private System.Windows.Forms.Label lblDiameterOutput;
        private System.Windows.Forms.Label lblSurfaceAreaOutput;
        private System.Windows.Forms.Label lblVolumeOutput;
        private System.Windows.Forms.PictureBox pictureSphere2;
        private System.Windows.Forms.Button btnCalculateEquations;
    }
}

