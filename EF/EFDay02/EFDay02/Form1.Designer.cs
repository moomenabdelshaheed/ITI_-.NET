namespace EFDay02
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
            cb_cat = new ComboBox();
            btn_delete = new Button();
            btn_update = new Button();
            cb_auth = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            textbref = new TextBox();
            texttitle = new TextBox();
            label1 = new Label();
            dgvnews = new DataGridView();
            add = new Button();
            richTextdesc = new RichTextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)dgvnews).BeginInit();
            SuspendLayout();
            // 
            // cb_cat
            // 
            cb_cat.FormattingEnabled = true;
            cb_cat.Location = new Point(750, 138);
            cb_cat.Name = "cb_cat";
            cb_cat.Size = new Size(182, 33);
            cb_cat.TabIndex = 44;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(957, 62);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(112, 34);
            btn_delete.TabIndex = 43;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(957, 131);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(112, 34);
            btn_update.TabIndex = 42;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // cb_auth
            // 
            cb_auth.FormattingEnabled = true;
            cb_auth.Location = new Point(750, 190);
            cb_auth.Name = "cb_auth";
            cb_auth.Size = new Size(182, 33);
            cb_auth.TabIndex = 41;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(627, 197);
            label6.Name = "label6";
            label6.Size = new Size(67, 25);
            label6.TabIndex = 40;
            label6.Text = "Author";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(627, 140);
            label5.Name = "label5";
            label5.Size = new Size(84, 25);
            label5.TabIndex = 39;
            label5.Text = "Category";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 146);
            label3.Name = "label3";
            label3.Size = new Size(102, 25);
            label3.TabIndex = 37;
            label3.Text = "Description";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(644, 81);
            label2.Name = "label2";
            label2.Size = new Size(43, 25);
            label2.TabIndex = 36;
            label2.Text = "Bref";
            label2.Click += label2_Click;
            // 
            // textbref
            // 
            textbref.Location = new Point(750, 81);
            textbref.Name = "textbref";
            textbref.Size = new Size(150, 31);
            textbref.TabIndex = 35;
            // 
            // texttitle
            // 
            texttitle.Location = new Point(750, 23);
            texttitle.Name = "texttitle";
            texttitle.Size = new Size(150, 31);
            texttitle.TabIndex = 32;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(644, 20);
            label1.Name = "label1";
            label1.Size = new Size(52, 25);
            label1.TabIndex = 31;
            label1.Text = "TITLE";
            // 
            // dgvnews
            // 
            dgvnews.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvnews.Location = new Point(0, 296);
            dgvnews.Name = "dgvnews";
            dgvnews.RowHeadersWidth = 62;
            dgvnews.Size = new Size(1240, 243);
            dgvnews.TabIndex = 30;
            dgvnews.RowHeaderMouseDoubleClick += dgvnews_RowHeaderMouseDoubleClick;
            // 
            // add
            // 
            add.Location = new Point(957, 188);
            add.Name = "add";
            add.Size = new Size(112, 34);
            add.TabIndex = 29;
            add.Text = "ADD";
            add.UseVisualStyleBackColor = true;
            add.Click += add_Click;
            // 
            // richTextdesc
            // 
            richTextdesc.Location = new Point(138, 133);
            richTextdesc.Name = "richTextdesc";
            richTextdesc.Size = new Size(422, 51);
            richTextdesc.TabIndex = 45;
            richTextdesc.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1252, 551);
            Controls.Add(richTextdesc);
            Controls.Add(cb_cat);
            Controls.Add(btn_delete);
            Controls.Add(btn_update);
            Controls.Add(cb_auth);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textbref);
            Controls.Add(texttitle);
            Controls.Add(label1);
            Controls.Add(dgvnews);
            Controls.Add(add);
            MaximumSize = new Size(1274, 607);
            MinimumSize = new Size(1274, 607);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvnews).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cb_cat;
        private Button btn_delete;
        private Button btn_update;
        private ComboBox cb_auth;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label2;
        private TextBox textbref;
        private TextBox texttitle;
        private Label label1;
        private DataGridView dgvnews;
        private Button add;
        private RichTextBox richTextdesc;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
