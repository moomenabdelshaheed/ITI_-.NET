namespace WindowsFormsApp1self_study
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_result = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.celsiusradiobutton = new System.Windows.Forms.RadioButton();
            this.fahrenheitradiobutton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(32, 109);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(216, 26);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Temprature :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox_result
            // 
            this.textBox_result.Location = new System.Drawing.Point(32, 303);
            this.textBox_result.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.ReadOnly = true;
            this.textBox_result.Size = new System.Drawing.Size(216, 26);
            this.textBox_result.TabIndex = 2;
            this.textBox_result.TextChanged += new System.EventHandler(this.textBox_result_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 248);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Result :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(358, 278);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 77);
            this.button1.TabIndex = 4;
            this.button1.Text = "Convert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // celsiusradiobutton
            // 
            this.celsiusradiobutton.AutoSize = true;
            this.celsiusradiobutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.celsiusradiobutton.Location = new System.Drawing.Point(333, 54);
            this.celsiusradiobutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.celsiusradiobutton.Name = "celsiusradiobutton";
            this.celsiusradiobutton.Size = new System.Drawing.Size(133, 36);
            this.celsiusradiobutton.TabIndex = 5;
            this.celsiusradiobutton.TabStop = true;
            this.celsiusradiobutton.Text = "Celsius";
            this.celsiusradiobutton.UseVisualStyleBackColor = true;
            this.celsiusradiobutton.CheckedChanged += new System.EventHandler(this.celsiusradiobutton_CheckedChanged);
            // 
            // fahrenheitradiobutton
            // 
            this.fahrenheitradiobutton.AutoSize = true;
            this.fahrenheitradiobutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fahrenheitradiobutton.Location = new System.Drawing.Point(333, 154);
            this.fahrenheitradiobutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fahrenheitradiobutton.Name = "fahrenheitradiobutton";
            this.fahrenheitradiobutton.Size = new System.Drawing.Size(176, 36);
            this.fahrenheitradiobutton.TabIndex = 6;
            this.fahrenheitradiobutton.TabStop = true;
            this.fahrenheitradiobutton.Text = "Fahrenheit";
            this.fahrenheitradiobutton.UseVisualStyleBackColor = true;
            this.fahrenheitradiobutton.CheckedChanged += new System.EventHandler(this.fahrenheitradiobutton_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 402);
            this.Controls.Add(this.fahrenheitradiobutton);
            this.Controls.Add(this.celsiusradiobutton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_result);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Moomen";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_result;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton celsiusradiobutton;
        private System.Windows.Forms.RadioButton fahrenheitradiobutton;
    }
}

