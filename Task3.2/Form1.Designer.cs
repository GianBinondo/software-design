namespace Task3._2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtBase = new TextBox();
            lblPowerResult = new Label();
            btnCalculatedPower = new Button();
            txtExponent = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtBase
            // 
            txtBase.Location = new Point(59, 87);
            txtBase.Name = "txtBase";
            txtBase.Size = new Size(198, 23);
            txtBase.TabIndex = 0;
            // 
            // lblPowerResult
            // 
            lblPowerResult.AutoSize = true;
            lblPowerResult.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPowerResult.Location = new Point(410, 151);
            lblPowerResult.Name = "lblPowerResult";
            lblPowerResult.Size = new Size(0, 86);
            lblPowerResult.TabIndex = 1;
            // 
            // btnCalculatedPower
            // 
            btnCalculatedPower.Location = new Point(59, 190);
            btnCalculatedPower.Name = "btnCalculatedPower";
            btnCalculatedPower.Size = new Size(198, 51);
            btnCalculatedPower.TabIndex = 2;
            btnCalculatedPower.Text = "Calculated Power";
            btnCalculatedPower.UseVisualStyleBackColor = true;
            btnCalculatedPower.Click += btnCalculatedPower_Click;
            // 
            // txtExponent
            // 
            txtExponent.Location = new Point(59, 143);
            txtExponent.Name = "txtExponent";
            txtExponent.Size = new Size(198, 23);
            txtExponent.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 69);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 4;
            label1.Text = "Base";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 125);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 5;
            label2.Text = "Exponent";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtExponent);
            Controls.Add(btnCalculatedPower);
            Controls.Add(lblPowerResult);
            Controls.Add(txtBase);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBase;
        private Label lblPowerResult;
        private Button btnCalculatedPower;
        private TextBox txtExponent;
        private Label label1;
        private Label label2;
    }
}
