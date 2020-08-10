namespace Temperature_Conversion
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Fahrenheit = new System.Windows.Forms.TextBox();
            this.txt_Celsius = new System.Windows.Forms.TextBox();
            this.txt_Kelvin = new System.Windows.Forms.TextBox();
            this.btn_Fahrenheit = new System.Windows.Forms.Button();
            this.btn_Celsius = new System.Windows.Forms.Button();
            this.btn_Kelvin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.label1.Location = new System.Drawing.Point(47, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fahrenheit";
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.label2.Location = new System.Drawing.Point(83, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 43);
            this.label2.TabIndex = 1;
            this.label2.Text = "Celsius";
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label3.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.label3.Location = new System.Drawing.Point(89, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 38);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kelvin";
            this.txt_Fahrenheit.Location = new System.Drawing.Point(201, 70);
            this.txt_Fahrenheit.Name = "txt_Fahrenheit";
            this.txt_Fahrenheit.Size = new System.Drawing.Size(170, 22);
            this.txt_Fahrenheit.TabIndex = 3;
            this.txt_Celsius.Location = new System.Drawing.Point(201, 131);
            this.txt_Celsius.Name = "txt_Celsius";
            this.txt_Celsius.Size = new System.Drawing.Size(169, 22);
            this.txt_Celsius.TabIndex = 4;
            this.txt_Kelvin.Location = new System.Drawing.Point(201, 185);
            this.txt_Kelvin.Name = "txt_Kelvin";
            this.txt_Kelvin.Size = new System.Drawing.Size(170, 22);
            this.txt_Kelvin.TabIndex = 5;
            this.btn_Fahrenheit.Location = new System.Drawing.Point(414, 67);
            this.btn_Fahrenheit.Name = "btn_Fahrenheit";
            this.btn_Fahrenheit.Size = new System.Drawing.Size(134, 29);
            this.btn_Fahrenheit.TabIndex = 6;
            this.btn_Fahrenheit.Text = "Convert";
            this.btn_Fahrenheit.UseVisualStyleBackColor = true;
            this.btn_Fahrenheit.Click += new System.EventHandler(this.btn_Fahrenheit_Click);
            this.btn_Celsius.Location = new System.Drawing.Point(414, 124);
            this.btn_Celsius.Name = "btn_Celsius";
            this.btn_Celsius.Size = new System.Drawing.Size(134, 29);
            this.btn_Celsius.TabIndex = 7;
            this.btn_Celsius.Text = "Convert";
            this.btn_Celsius.UseVisualStyleBackColor = true;
            this.btn_Celsius.Click += new System.EventHandler(this.btn_Celsius_Click);
            this.btn_Kelvin.Location = new System.Drawing.Point(414, 178);
            this.btn_Kelvin.Name = "btn_Kelvin";
            this.btn_Kelvin.Size = new System.Drawing.Size(134, 29);
            this.btn_Kelvin.TabIndex = 8;
            this.btn_Kelvin.Text = "Convert";
            this.btn_Kelvin.UseVisualStyleBackColor = true;
            this.btn_Kelvin.Click += new System.EventHandler(this.btn_Kelvin_Click);
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 460);
            this.Controls.Add(this.btn_Kelvin);
            this.Controls.Add(this.btn_Celsius);
            this.Controls.Add(this.btn_Fahrenheit);
            this.Controls.Add(this.txt_Kelvin);
            this.Controls.Add(this.txt_Celsius);
            this.Controls.Add(this.txt_Fahrenheit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btn_Celsius;
        private System.Windows.Forms.Button btn_Fahrenheit;
        private System.Windows.Forms.Button btn_Kelvin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Celsius;
        private System.Windows.Forms.TextBox txt_Fahrenheit;
        private System.Windows.Forms.TextBox txt_Kelvin;

        #endregion
    }
}