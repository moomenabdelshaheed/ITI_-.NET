using EFDay02.Model;
using Microsoft.EntityFrameworkCore;
using static EFDay02.Model.journalContext;

namespace EFDay02
{
    public partial class Form1 : Form
    {
        journalContext db;
        int? x = null;
        public Form1()
        {
            InitializeComponent();
            db = new journalContext();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            journalContext db = new journalContext();
            var list = db.News.Include(x=>x.Author).Include(y=>y.Category);
            //foreach (var item in list)
            //{
            //    MessageBox.Show("item " + item.Author.Name);
            //    MessageBox.Show("item " + item.Category.Name);

            //}
            dgvnews.DataSource = db.News.Select(n=> new {n.Id,n.Title,n.bref,n.Description,n.DateTime,Category=n.Category.Name,Author=n.Author.Name}).ToList();
            cb_cat.DataSource = db.Categories.ToList();
            cb_cat.ValueMember = "Id";
            cb_cat.DisplayMember = "Name";
            cb_auth.DataSource = db.Authors.ToList();
            cb_auth.ValueMember = "Id";
            cb_auth.DisplayMember = "Name";
            add.Enabled = true;
            btn_update.Enabled = false;
            btn_delete.Enabled = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textage_TextChanged(object sender, EventArgs e)
        {
            
        }
        int id;
        private void dgvnews_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = (int)dgvnews.SelectedRows[0].Cells[0].Value;

            //News news = new News();
            News news = db.News.Where(x => x.Id == id).SingleOrDefault();
            texttitle.Text = news.Title;
            //textbref.Text = string.IsNullOrEmpty(news.bref) ? "Empty Data" : "it is not null";
            if (news.bref == null)
            {
                textbref.Text = "bref is NULL";
            }
            else if (news.bref == "")
            {
                textbref.Text = "bref is EMPTY STRING";
            }
            else
            {
                textbref.Text = news.bref;
            }

            //textbref.Text = news.bref?? "Empty Data";
            richTextdesc.Text = news.Description??"Empty Data";
            cb_cat.SelectedValue = news.CatId;
            cb_auth.SelectedValue = news.AuthorId;
            add.Enabled = false;
            btn_update.Enabled = true;
            btn_delete.Enabled = true;
        }

        private void add_Click(object sender, EventArgs e)
        {
            


                News news = new News()
                {

                    Title = texttitle.Text,
                    bref = textbref.Text,
                    Description = richTextdesc.Text,
                    CatId = (int)cb_cat.SelectedValue,
                    AuthorId = (int)cb_auth.SelectedValue,
                };

                db.News.Add(news);
                db.SaveChanges();
            var migrationHelper = new MigrationHelper(db);
            migrationHelper.ReseedIdentity();
            dgvnews.DataSource = db.News.ToList();
                texttitle.Text = textbref.Text = richTextdesc.Text = "";
                MessageBox.Show("Added");

            
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            News news = db.News.Where(n => n.Id == id).SingleOrDefault();
            news.Title = texttitle.Text; news.bref = textbref.Text;
            news.Description = richTextdesc.Text;
            news.CatId = (int)cb_cat.SelectedValue;
            news.AuthorId = (int)cb_auth.SelectedValue;
            db.SaveChanges();
            dgvnews.DataSource = db.News.ToList();
            texttitle.Text = textbref.Text = richTextdesc.Text = "";
            add.Enabled = true;
            btn_update.Enabled = false;
            btn_delete.Enabled = false;
            MessageBox.Show("Updated");
            MessageBox.Show(e.ToString());

            
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this ", "confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes) { 
            News news = db.News.Where(n=>n.Id == id).SingleOrDefault();
                db.News.Remove(news);
                db.SaveChanges();
                texttitle.Text = textbref.Text = richTextdesc.Text = "";
                dgvnews.DataSource= db.News.ToList();
                add.Enabled = true;
                btn_update.Enabled = false;
                btn_delete.Enabled = false;
                MessageBox.Show("Deleted");

            }
        }
    }
}
