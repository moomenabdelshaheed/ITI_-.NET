namespace WinFormswirhwebapi
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
            text_name = new TextBox();
            text_duration = new TextBox();
            dataGridView1 = new DataGridView();
            btn_add = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            richText_desc = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // text_name
            // 
            text_name.Location = new Point(120, 31);
            text_name.Name = "text_name";
            text_name.Size = new Size(242, 31);
            text_name.TabIndex = 0;
            // 
            // text_duration
            // 
            text_duration.Location = new Point(120, 193);
            text_duration.Name = "text_duration";
            text_duration.Size = new Size(242, 31);
            text_duration.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 235);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(776, 203);
            dataGridView1.TabIndex = 5;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(450, 34);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(112, 34);
            btn_add.TabIndex = 6;
            btn_add.Text = "ADD";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 34);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 7;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 87);
            label2.Name = "label2";
            label2.Size = new Size(102, 25);
            label2.TabIndex = 8;
            label2.Text = "Description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 199);
            label3.Name = "label3";
            label3.Size = new Size(81, 25);
            label3.TabIndex = 9;
            label3.Text = "Duration";
            // 
            // richText_desc
            // 
            richText_desc.Location = new Point(120, 87);
            richText_desc.Name = "richText_desc";
            richText_desc.Size = new Size(242, 76);
            richText_desc.TabIndex = 11;
            richText_desc.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richText_desc);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_add);
            Controls.Add(dataGridView1);
            Controls.Add(text_duration);
            Controls.Add(text_name);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox text_name;
        private TextBox text_duration;
        private DataGridView dataGridView1;
        private Button btn_add;
        private Label label1;
        private Label label2;
        private Label label3;
        private RichTextBox richText_desc;
    }
}
