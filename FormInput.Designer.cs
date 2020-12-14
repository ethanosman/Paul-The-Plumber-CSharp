
namespace PaulsTimber
{
    partial class FormInput
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
            this.lblJobCalculator = new System.Windows.Forms.Label();
            this.lblLabour = new System.Windows.Forms.Label();
            this.lblTravel = new System.Windows.Forms.Label();
            this.lblPipes = new System.Windows.Forms.Label();
            this.pnlCosts = new System.Windows.Forms.Panel();
            this.lblLabourHours = new System.Windows.Forms.Label();
            this.txtLabourHours = new System.Windows.Forms.TextBox();
            this.lblTravelLength = new System.Windows.Forms.Label();
            this.txtTravelLength = new System.Windows.Forms.TextBox();
            this.lblPlasticPipeLength = new System.Windows.Forms.Label();
            this.txtPlasticPipeLength = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblLabourCosts = new System.Windows.Forms.Label();
            this.pnlInputs = new System.Windows.Forms.Panel();
            this.lblTravelCosts = new System.Windows.Forms.Label();
            this.lblPlasticPipeCosts = new System.Windows.Forms.Label();
            this.lblTotalCosts = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlCosts.SuspendLayout();
            this.pnlInputs.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblJobCalculator
            // 
            this.lblJobCalculator.AutoSize = true;
            this.lblJobCalculator.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblJobCalculator.Location = new System.Drawing.Point(46, 38);
            this.lblJobCalculator.Name = "lblJobCalculator";
            this.lblJobCalculator.Size = new System.Drawing.Size(140, 37);
            this.lblJobCalculator.TabIndex = 0;
            this.lblJobCalculator.Text = "Job Quote";
            // 
            // lblLabour
            // 
            this.lblLabour.AutoSize = true;
            this.lblLabour.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLabour.Location = new System.Drawing.Point(12, 0);
            this.lblLabour.Name = "lblLabour";
            this.lblLabour.Size = new System.Drawing.Size(143, 17);
            this.lblLabour.TabIndex = 1;
            this.lblLabour.Text = "Labour = £35 Per Hour";
            // 
            // lblTravel
            // 
            this.lblTravel.AutoSize = true;
            this.lblTravel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTravel.Location = new System.Drawing.Point(12, 32);
            this.lblTravel.Name = "lblTravel";
            this.lblTravel.Size = new System.Drawing.Size(125, 17);
            this.lblTravel.TabIndex = 2;
            this.lblTravel.Text = "Travel = £2 Per Mile";
            // 
            // lblPipes
            // 
            this.lblPipes.AutoSize = true;
            this.lblPipes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPipes.Location = new System.Drawing.Point(12, 59);
            this.lblPipes.Name = "lblPipes";
            this.lblPipes.Size = new System.Drawing.Size(176, 17);
            this.lblPipes.TabIndex = 3;
            this.lblPipes.Text = "Plastic Pipes  = £3 Per Meter";
            // 
            // pnlCosts
            // 
            this.pnlCosts.Controls.Add(this.lblPipes);
            this.pnlCosts.Controls.Add(this.lblTravel);
            this.pnlCosts.Controls.Add(this.lblLabour);
            this.pnlCosts.Location = new System.Drawing.Point(242, 22);
            this.pnlCosts.Name = "pnlCosts";
            this.pnlCosts.Size = new System.Drawing.Size(194, 85);
            this.pnlCosts.TabIndex = 4;
            // 
            // lblLabourHours
            // 
            this.lblLabourHours.AutoSize = true;
            this.lblLabourHours.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLabourHours.Location = new System.Drawing.Point(12, 13);
            this.lblLabourHours.Name = "lblLabourHours";
            this.lblLabourHours.Size = new System.Drawing.Size(124, 25);
            this.lblLabourHours.TabIndex = 5;
            this.lblLabourHours.Text = "Labour Hours:";
            // 
            // txtLabourHours
            // 
            this.txtLabourHours.Location = new System.Drawing.Point(179, 16);
            this.txtLabourHours.Name = "txtLabourHours";
            this.txtLabourHours.Size = new System.Drawing.Size(119, 23);
            this.txtLabourHours.TabIndex = 6;
            this.txtLabourHours.Text = "0";
            // 
            // lblTravelLength
            // 
            this.lblTravelLength.AutoSize = true;
            this.lblTravelLength.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTravelLength.Location = new System.Drawing.Point(12, 72);
            this.lblTravelLength.Name = "lblTravelLength";
            this.lblTravelLength.Size = new System.Drawing.Size(119, 25);
            this.lblTravelLength.TabIndex = 7;
            this.lblTravelLength.Text = "Travel Length:";
            // 
            // txtTravelLength
            // 
            this.txtTravelLength.Location = new System.Drawing.Point(179, 74);
            this.txtTravelLength.Name = "txtTravelLength";
            this.txtTravelLength.Size = new System.Drawing.Size(119, 23);
            this.txtTravelLength.TabIndex = 8;
            this.txtTravelLength.Text = "0";
            // 
            // lblPlasticPipeLength
            // 
            this.lblPlasticPipeLength.AutoSize = true;
            this.lblPlasticPipeLength.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPlasticPipeLength.Location = new System.Drawing.Point(12, 130);
            this.lblPlasticPipeLength.Name = "lblPlasticPipeLength";
            this.lblPlasticPipeLength.Size = new System.Drawing.Size(163, 25);
            this.lblPlasticPipeLength.TabIndex = 9;
            this.lblPlasticPipeLength.Text = "Plastic Pipe Length:";
            // 
            // txtPlasticPipeLength
            // 
            this.txtPlasticPipeLength.Location = new System.Drawing.Point(179, 130);
            this.txtPlasticPipeLength.Name = "txtPlasticPipeLength";
            this.txtPlasticPipeLength.Size = new System.Drawing.Size(119, 23);
            this.txtPlasticPipeLength.TabIndex = 10;
            this.txtPlasticPipeLength.Text = "0";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCalculate.Location = new System.Drawing.Point(426, 124);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(86, 52);
            this.btnCalculate.TabIndex = 11;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClear.Location = new System.Drawing.Point(426, 196);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(86, 52);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExit.Location = new System.Drawing.Point(426, 271);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(86, 52);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblLabourCosts
            // 
            this.lblLabourCosts.AutoSize = true;
            this.lblLabourCosts.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLabourCosts.Location = new System.Drawing.Point(12, 3);
            this.lblLabourCosts.Name = "lblLabourCosts";
            this.lblLabourCosts.Size = new System.Drawing.Size(136, 23);
            this.lblLabourCosts.TabIndex = 14;
            this.lblLabourCosts.Text = "Labour Costs: £0";
            // 
            // pnlInputs
            // 
            this.pnlInputs.Controls.Add(this.txtPlasticPipeLength);
            this.pnlInputs.Controls.Add(this.lblPlasticPipeLength);
            this.pnlInputs.Controls.Add(this.txtTravelLength);
            this.pnlInputs.Controls.Add(this.lblTravelLength);
            this.pnlInputs.Controls.Add(this.txtLabourHours);
            this.pnlInputs.Controls.Add(this.lblLabourHours);
            this.pnlInputs.Location = new System.Drawing.Point(34, 124);
            this.pnlInputs.Name = "pnlInputs";
            this.pnlInputs.Size = new System.Drawing.Size(309, 169);
            this.pnlInputs.TabIndex = 15;
            // 
            // lblTravelCosts
            // 
            this.lblTravelCosts.AutoSize = true;
            this.lblTravelCosts.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTravelCosts.Location = new System.Drawing.Point(12, 39);
            this.lblTravelCosts.Name = "lblTravelCosts";
            this.lblTravelCosts.Size = new System.Drawing.Size(127, 23);
            this.lblTravelCosts.TabIndex = 16;
            this.lblTravelCosts.Text = "Travel Costs: £0";
            // 
            // lblPlasticPipeCosts
            // 
            this.lblPlasticPipeCosts.AutoSize = true;
            this.lblPlasticPipeCosts.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPlasticPipeCosts.Location = new System.Drawing.Point(12, 73);
            this.lblPlasticPipeCosts.Name = "lblPlasticPipeCosts";
            this.lblPlasticPipeCosts.Size = new System.Drawing.Size(169, 23);
            this.lblPlasticPipeCosts.TabIndex = 17;
            this.lblPlasticPipeCosts.Text = "Plastic Pipe Costs: £0";
            // 
            // lblTotalCosts
            // 
            this.lblTotalCosts.AutoSize = true;
            this.lblTotalCosts.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalCosts.Location = new System.Drawing.Point(13, 107);
            this.lblTotalCosts.Name = "lblTotalCosts";
            this.lblTotalCosts.Size = new System.Drawing.Size(126, 23);
            this.lblTotalCosts.TabIndex = 18;
            this.lblTotalCosts.Text = "Total Costs: £0";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTotalCosts);
            this.panel1.Controls.Add(this.lblPlasticPipeCosts);
            this.panel1.Controls.Add(this.lblTravelCosts);
            this.panel1.Controls.Add(this.lblLabourCosts);
            this.panel1.Location = new System.Drawing.Point(34, 318);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 140);
            this.panel1.TabIndex = 19;
            // 
            // FormInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 521);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlInputs);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.pnlCosts);
            this.Controls.Add(this.lblJobCalculator);
            this.Name = "FormInput";
            this.Text = "Job Quote";
            this.Load += new System.EventHandler(this.FormInput_Load);
            this.pnlCosts.ResumeLayout(false);
            this.pnlCosts.PerformLayout();
            this.pnlInputs.ResumeLayout(false);
            this.pnlInputs.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblJobCalculator;
        private System.Windows.Forms.Label lblLabour;
        private System.Windows.Forms.Label lblTravel;
        private System.Windows.Forms.Label lblPipes;
        private System.Windows.Forms.Panel pnlCosts;
        private System.Windows.Forms.Label lblLabourHours;
        private System.Windows.Forms.TextBox txtLabourHours;
        private System.Windows.Forms.Label lblTravelLength;
        private System.Windows.Forms.TextBox txtTravelLength;
        private System.Windows.Forms.Label lblPlasticPipeLength;
        private System.Windows.Forms.TextBox txtPlasticPipeLength;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblLabourCosts;
        private System.Windows.Forms.Panel pnlInputs;
        private System.Windows.Forms.Label lblTravelCosts;
        private System.Windows.Forms.Label lblPlasticPipeCosts;
        private System.Windows.Forms.Label lblTotalCosts;
        private System.Windows.Forms.Panel panel1;
    }
}