using WinFormsApp1.Models;

namespace WinFormsApp1
{

    public partial class Form1 : Form
    {
        ITIContext db;
        public Form1()
        {
            db = new ITIContext();
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ITIContext db = new ITIContext();
            dgvstud.DataSource = db.Students.ToList();
            var students = db.Students.ToList();
            students.Insert(0, new Student { StudentId = 0, FName = "" });
            cb_super.DataSource = students;
            var depts = db.Departments.ToList();
            depts.Insert(0,new Department { Dept_Id = -1, Dept_Name = ""});
            cb_dept.DataSource = depts;
            cb_dept.ValueMember = "Dept_Id";
            cb_dept.DisplayMember = "Dept_Name";
            cb_super.ValueMember = "StudentId";
            cb_super.DisplayMember = "FName";
            btn_update.Enabled = false;
            btn_delete.Enabled = false;
        }

        private void add_Click(object sender, EventArgs e)
        {
            Student s = new Student()
            {

                FName = textFname.Text,
                LName = textlname.Text,
                Addresss = textaddress.Text,
                Age = int.Parse(textage.Text),
                Dept_Id = (int)cb_dept.SelectedValue,
                St_Super = (int)cb_super.SelectedValue == 0 ? null : (int?)cb_super.SelectedValue
                //St_Super = (int)cb_super.SelectedValue,


            };
            db.Students.Add(s);
            db.SaveChanges();
            textlname.Text = textFname.Text = textaddress.Text = textage.Text = "";
            dgvstud.DataSource = db.Students.ToList();
            MessageBox.Show("Added");
        }
        int id;

        private void dgvstud_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = (int)dgvstud.SelectedRows[0].Cells[0].Value;
            //textFname.Text = dgvstud.SelectedRows[0].Cells[1].Value.ToString();
            //textlname.Text = dgvstud.SelectedRows[0].Cells[2].Value.ToString();
            //textaddress.Text = dgvstud.SelectedRows[0].Cells[3].Value.ToString();
            //textage.Text = dgvstud.SelectedRows[0].Cells[4].Value.ToString();
            //textdept.Text = dgvstud.SelectedRows[0].Cells[5].Value.ToString();
            //cb_super.SelectedValue = dgvstud.SelectedRows[0].Cells[6].Value.ToString();
            Student s = db.Students.Where(x => x.StudentId == id).SingleOrDefault();
            textFname.Text = s.FName;
            textlname.Text = s.LName;
            textaddress.Text = s.Addresss;
            textage.Text = s.Age.ToString();
            cb_dept.SelectedValue = s.Dept_Id;
            //cb_super.DataSource = db.Students.ToList();
            if (s.St_Super != null)
            {
                cb_super.SelectedValue = s.St_Super;
            }
            else
            {
                cb_super.SelectedIndex = -1;
            }

            //cb_super.SelectedValue = s.St_Super?cb_super.SelectedIndex=-1;
            btn_update.Enabled = true;
            add.Enabled = false;
            btn_delete.Enabled = true;


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Student s = db.Students.Where(n => n.StudentId == id).SingleOrDefault();
            s.FName = textFname.Text;
            s.LName = textlname.Text.ToString();
            s.Addresss = textaddress.Text;
            s.Age = int.Parse(textage.Text);
            s.Dept_Id = (int)cb_dept.SelectedValue;
            //s.St_Super = (int)cb_super.SelectedValue;
            if (cb_super.SelectedIndex != -1)
            {
                s.St_Super = (int)cb_super.SelectedValue;
            }
            else
            {
                s.St_Super = null;
            }
            db.SaveChanges();
            textaddress.Text = textage.Text =  textFname.Text = textlname.Text = "";
            dgvstud.DataSource = db.Students.ToList();
            MessageBox.Show("updated");
            btn_update.Enabled = false;
            btn_delete.Enabled = false;
            add.Enabled = true;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you want to delete this student", "confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes) { 
            Student s= db.Students.Where(n=>n.StudentId==id).SingleOrDefault();
            
                db.Students.Remove(s);
                db.SaveChanges();
                textaddress.Text = textage.Text =  textFname.Text = textlname.Text = "";
                dgvstud.DataSource = db.Students.ToList();
                MessageBox.Show("Deleted Succsessfully");
                btn_update.Enabled = false;
                btn_delete.Enabled = false;
                add.Enabled = true;

            }
        }
    }
}
