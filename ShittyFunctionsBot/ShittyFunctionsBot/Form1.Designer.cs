namespace ShittyFunctionsBot
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
            this.btnRomanConverter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRomanConverter
            // 
            this.btnRomanConverter.Location = new System.Drawing.Point(21, 31);
            this.btnRomanConverter.Name = "btnRomanConverter";
            this.btnRomanConverter.Size = new System.Drawing.Size(140, 23);
            this.btnRomanConverter.TabIndex = 0;
            this.btnRomanConverter.Text = "Roman numeral converter";
            this.btnRomanConverter.UseVisualStyleBackColor = true;
            this.btnRomanConverter.Click += new System.EventHandler(this.btnRomanConverter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnRomanConverter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRomanConverter;
    }
}

