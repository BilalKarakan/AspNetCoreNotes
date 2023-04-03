namespace Senkron_Asenkron
{
    partial class Form1
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
            this.btnSum = new System.Windows.Forms.Button();
            this.btnMultiplication = new System.Windows.Forms.Button();
            this.btn = new System.Windows.Forms.TextBox();
            this.btn2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(109, 237);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(75, 23);
            this.btnSum.TabIndex = 0;
            this.btnSum.Text = "Sum";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // btnMultiplication
            // 
            this.btnMultiplication.Location = new System.Drawing.Point(356, 237);
            this.btnMultiplication.Name = "btnMultiplication";
            this.btnMultiplication.Size = new System.Drawing.Size(137, 23);
            this.btnMultiplication.TabIndex = 1;
            this.btnMultiplication.Text = "Multiplication";
            this.btnMultiplication.UseVisualStyleBackColor = true;
            this.btnMultiplication.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(83, 80);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(100, 22);
            this.btn.TabIndex = 2;
            this.btn.TextChanged += new System.EventHandler(this.btnSum_TextChanged);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(331, 80);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(100, 22);
            this.btn2.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.btnMultiplication);
            this.Controls.Add(this.btnSum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnMultiplication;
        private System.Windows.Forms.TextBox btn;
        private System.Windows.Forms.TextBox btn2;
    }
}

