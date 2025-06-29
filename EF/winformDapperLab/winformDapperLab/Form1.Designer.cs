namespace winformDapperLab
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
            textduration = new TextBox();
            textname = new TextBox();
            cb_topicname = new ComboBox();
            button1 = new Button();
            btn_update = new Button();
            btn_delete = new Button();
            dgv_course = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_course).BeginInit();
            SuspendLayout();
            // 
            // textduration
            // 
            textduration.Location = new Point(527, 73);
            textduration.Name = "textduration";
            textduration.Size = new Size(150, 31);
            textduration.TabIndex = 0;
            // 
            // textname
            // 
            textname.Location = new Point(134, 73);
            textname.Name = "textname";
            textname.Size = new Size(150, 31);
            textname.TabIndex = 1;
            // 
            // cb_topicname
            // 
            cb_topicname.FormattingEnabled = true;
            cb_topicname.Location = new Point(873, 73);
            cb_topicname.Name = "cb_topicname";
            cb_topicname.Size = new Size(182, 33);
            cb_topicname.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(358, 150);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 3;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(497, 150);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(112, 34);
            btn_update.TabIndex = 4;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(637, 150);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(112, 34);
            btn_delete.TabIndex = 5;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // dgv_course
            // 
            dgv_course.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_course.Location = new Point(12, 261);
            dgv_course.Name = "dgv_course";
            dgv_course.RowHeadersWidth = 62;
            dgv_course.Size = new Size(1233, 232);
            dgv_course.TabIndex = 6;
            dgv_course.RowHeaderMouseDoubleClick += dgv_course_RowHeaderMouseDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 77);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 7;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(411, 81);
            label2.Name = "label2";
            label2.Size = new Size(81, 25);
            label2.TabIndex = 8;
            label2.Text = "Duration";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(760, 81);
            label3.Name = "label3";
            label3.Size = new Size(53, 25);
            label3.TabIndex = 9;
            label3.Text = "Topic";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1249, 494);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgv_course);
            Controls.Add(btn_delete);
            Controls.Add(btn_update);
            Controls.Add(button1);
            Controls.Add(cb_topicname);
            Controls.Add(textname);
            Controls.Add(textduration);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_course).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textduration;
        private TextBox textname;
        private ComboBox cb_topicname;
        private Button button1;
        private Button btn_update;
        private Button btn_delete;
        private DataGridView dgv_course;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
