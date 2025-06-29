namespace WinFormsApp1
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
            add = new Button();
            dgvstud = new DataGridView();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            textlname = new TextBox();
            textaddress = new TextBox();
            textage = new TextBox();
            textFname = new TextBox();
            label1 = new Label();
            label6 = new Label();
            cb_super = new ComboBox();
            btn_update = new Button();
            btn_delete = new Button();
            cb_dept = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvstud).BeginInit();
            SuspendLayout();
            // 
            // add
            // 
            add.Location = new Point(1196, 234);
            add.Name = "add";
            add.Size = new Size(112, 34);
            add.TabIndex = 0;
            add.Text = "ADD";
            add.UseVisualStyleBackColor = true;
            add.Click += add_Click;
            // 
            // dgvstud
            // 
            dgvstud.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvstud.Location = new Point(-2, 288);
            dgvstud.Name = "dgvstud";
            dgvstud.RowHeadersWidth = 62;
            dgvstud.Size = new Size(1355, 222);
            dgvstud.TabIndex = 11;
            dgvstud.RowHeaderMouseDoubleClick += dgvstud_RowHeaderMouseDoubleClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(883, 162);
            label5.Name = "label5";
            label5.Size = new Size(73, 25);
            label5.TabIndex = 21;
            label5.Text = "Dept_id";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(883, 128);
            label4.Name = "label4";
            label4.Size = new Size(44, 25);
            label4.TabIndex = 19;
            label4.Text = "Age";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(883, 94);
            label3.Name = "label3";
            label3.Size = new Size(77, 25);
            label3.TabIndex = 18;
            label3.Text = "Address";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(883, 51);
            label2.Name = "label2";
            label2.Size = new Size(67, 25);
            label2.TabIndex = 17;
            label2.Text = "LName";
            // 
            // textlname
            // 
            textlname.Location = new Point(989, 51);
            textlname.Name = "textlname";
            textlname.Size = new Size(150, 31);
            textlname.TabIndex = 16;
            // 
            // textaddress
            // 
            textaddress.Location = new Point(989, 88);
            textaddress.Name = "textaddress";
            textaddress.Size = new Size(150, 31);
            textaddress.TabIndex = 15;
            // 
            // textage
            // 
            textage.Location = new Point(989, 125);
            textage.Name = "textage";
            textage.Size = new Size(150, 31);
            textage.TabIndex = 14;
            // 
            // textFname
            // 
            textFname.Location = new Point(989, 14);
            textFname.Name = "textFname";
            textFname.Size = new Size(150, 31);
            textFname.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(883, 11);
            label1.Name = "label1";
            label1.Size = new Size(68, 25);
            label1.TabIndex = 12;
            label1.Text = "FName";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(883, 205);
            label6.Name = "label6";
            label6.Size = new Size(80, 25);
            label6.TabIndex = 22;
            label6.Text = "St_Super";
            // 
            // cb_super
            // 
            cb_super.FormattingEnabled = true;
            cb_super.Location = new Point(989, 202);
            cb_super.Name = "cb_super";
            cb_super.Size = new Size(182, 33);
            cb_super.TabIndex = 23;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(1196, 179);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(112, 34);
            btn_update.TabIndex = 24;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(1196, 122);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(112, 34);
            btn_delete.TabIndex = 27;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // cb_dept
            // 
            cb_dept.FormattingEnabled = true;
            cb_dept.Location = new Point(989, 163);
            cb_dept.Name = "cb_dept";
            cb_dept.Size = new Size(182, 33);
            cb_dept.TabIndex = 28;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1358, 555);
            Controls.Add(cb_dept);
            Controls.Add(btn_delete);
            Controls.Add(btn_update);
            Controls.Add(cb_super);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textlname);
            Controls.Add(textaddress);
            Controls.Add(textage);
            Controls.Add(textFname);
            Controls.Add(label1);
            Controls.Add(dgvstud);
            Controls.Add(add);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvstud).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button add;
        private DataGridView dgvstud;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textlname;
        private TextBox textaddress;
        private TextBox textage;
        private TextBox textFname;
        private Label label1;
        private Label label6;
        private ComboBox cb_super;
        private Button btn_update;
        private Button btn_delete;
        private ComboBox cb_dept;
    }
}
