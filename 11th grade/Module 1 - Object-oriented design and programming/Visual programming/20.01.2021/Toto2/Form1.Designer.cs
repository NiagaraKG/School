namespace Toto2
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
            this.labelNumbers = new System.Windows.Forms.Label();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.buttonClean = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNumbers
            // 
            this.labelNumbers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelNumbers.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.labelNumbers.Location = new System.Drawing.Point(53, 34);
            this.labelNumbers.Name = "labelNumbers";
            this.labelNumbers.Size = new System.Drawing.Size(326, 47);
            this.labelNumbers.TabIndex = 0;
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonGenerate.Location = new System.Drawing.Point(33, 117);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(161, 55);
            this.buttonGenerate.TabIndex = 1;
            this.buttonGenerate.Text = "Генерирай";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // buttonClean
            // 
            this.buttonClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonClean.Location = new System.Drawing.Point(234, 117);
            this.buttonClean.Name = "buttonClean";
            this.buttonClean.Size = new System.Drawing.Size(161, 55);
            this.buttonClean.TabIndex = 2;
            this.buttonClean.Text = "Изчисти";
            this.buttonClean.UseVisualStyleBackColor = true;
            this.buttonClean.Click += new System.EventHandler(this.buttonClean_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 206);
            this.Controls.Add(this.buttonClean);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.labelNumbers);
            this.Name = "Form1";
            this.Text = "Тото 2: 6 от 49";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelNumbers;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Button buttonClean;
    }
}

