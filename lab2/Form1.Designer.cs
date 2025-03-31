namespace lab2
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
            btnCalculateFactorial = new Button();
            txtInput = new TextBox();
            lblResult = new Label();
            btnCalculateSum = new Button();
            txtArrayInput = new TextBox();
            lblSumResult = new Label();
            SuspendLayout();
            // 
            // btnCalculateFactorial
            // 
            btnCalculateFactorial.Location = new Point(26, 99);
            btnCalculateFactorial.Name = "btnCalculateFactorial";
            btnCalculateFactorial.Size = new Size(201, 65);
            btnCalculateFactorial.TabIndex = 0;
            btnCalculateFactorial.Text = "Calculate Factorial";
            btnCalculateFactorial.UseVisualStyleBackColor = true;
            btnCalculateFactorial.Click += btnCalculateFactorial_Click;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(27, 58);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(200, 23);
            txtInput.TabIndex = 1;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResult.Location = new Point(306, 67);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 86);
            lblResult.TabIndex = 2;
            // 
            // btnCalculateSum
            // 
            btnCalculateSum.Location = new Point(27, 257);
            btnCalculateSum.Name = "btnCalculateSum";
            btnCalculateSum.Size = new Size(200, 64);
            btnCalculateSum.TabIndex = 3;
            btnCalculateSum.Text = "Calculate Sum";
            btnCalculateSum.UseVisualStyleBackColor = true;
            btnCalculateSum.Click += btnCalculateSum_Click;
            // 
            // txtArrayInput
            // 
            txtArrayInput.Location = new Point(26, 208);
            txtArrayInput.Name = "txtArrayInput";
            txtArrayInput.Size = new Size(200, 23);
            txtArrayInput.TabIndex = 4;
            // 
            // lblSumResult
            // 
            lblSumResult.AutoSize = true;
            lblSumResult.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSumResult.Location = new Point(306, 225);
            lblSumResult.Name = "lblSumResult";
            lblSumResult.Size = new Size(0, 86);
            lblSumResult.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblSumResult);
            Controls.Add(txtArrayInput);
            Controls.Add(btnCalculateSum);
            Controls.Add(lblResult);
            Controls.Add(txtInput);
            Controls.Add(btnCalculateFactorial);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalculateFactorial;
        private TextBox txtInput;
        private Label lblResult;
        private Button btnCalculateSum;
        private TextBox txtArrayInput;
        private Label lblSumResult;
    }
}
