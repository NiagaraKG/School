namespace FindMinimal
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.buttonMin = new System.Windows.Forms.Button();
            this.textBoxMin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(33, 36);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(113, 254);
            this.listBox1.TabIndex = 0;
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonGenerate.Location = new System.Drawing.Point(183, 245);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(143, 45);
            this.buttonGenerate.TabIndex = 1;
            this.buttonGenerate.Text = "Генериране";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // buttonMin
            // 
            this.buttonMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonMin.Location = new System.Drawing.Point(183, 88);
            this.buttonMin.Name = "buttonMin";
            this.buttonMin.Size = new System.Drawing.Size(143, 60);
            this.buttonMin.TabIndex = 2;
            this.buttonMin.Text = "Минимален елемент";
            this.buttonMin.UseVisualStyleBackColor = true;
            this.buttonMin.Click += new System.EventHandler(this.buttonMin_Click);
            // 
            // textBoxMin
            // 
            this.textBoxMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxMin.Location = new System.Drawing.Point(183, 36);
            this.textBoxMin.Name = "textBoxMin";
            this.textBoxMin.Size = new System.Drawing.Size(143, 30);
            this.textBoxMin.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 325);
            this.Controls.Add(this.textBoxMin);
            this.Controls.Add(this.buttonMin);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Find Minimal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Button buttonMin;
        private System.Windows.Forms.TextBox textBoxMin;
    }
}

