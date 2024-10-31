namespace Lab_2
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
            this.txtLimit = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lstFibonacci = new System.Windows.Forms.ListBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // txtLimit
            this.txtLimit.Location = new System.Drawing.Point(12, 12);
            this.txtLimit.Name = "txtLimit";
            this.txtLimit.Size = new System.Drawing.Size(100, 20);
            this.txtLimit.TabIndex = 0;

            // btnCalculate
            this.btnCalculate.Location = new System.Drawing.Point(118, 10);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "Посчитать";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);

            // lstFibonacci
            this.lstFibonacci.FormattingEnabled = true;
            this.lstFibonacci.Location = new System.Drawing.Point(12, 38);
            this.lstFibonacci.Name = "lstFibonacci";
            this.lstFibonacci.Size = new System.Drawing.Size(181, 160);
            this.lstFibonacci.TabIndex = 2;

            // lblStatus
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(12, 201);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 13);
            this.lblStatus.TabIndex = 3;

            // MainForm
            this.ClientSize = new System.Drawing.Size(220, 230);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lstFibonacci);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtLimit);
            this.Name = "MainForm";
            this.Text = "Числа Фибоначчи";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private TextBox txtLimit;
        private Button btnCalculate;
        private ListBox lstFibonacci;
        private Label lblStatus;
    }
}
