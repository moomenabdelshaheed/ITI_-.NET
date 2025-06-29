using Dapper;
using Microsoft.Data.SqlClient;
using winformDapperLab.classes;

namespace winformDapperLab
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        int id;

        public Form1()
        {

            InitializeComponent();
            con = new SqlConnection("Data Source=MOOMEN\\SQLEXPRESS;Initial Catalog=ITI;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
            var q1 = con.Query<Course>("select c.*,T.top_name from course c inner join Topic T on c.top_id = t.top_id ");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var con = new SqlConnection("Data Source=MOOMEN\\SQLEXPRESS;Initial Catalog=ITI;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
            var q1 = con.Query<Course>("select c.*,T.top_name from course c inner join Topic T on c.top_id = t.top_id ");
            dgv_course.DataSource = q1.ToList();
            var q2 = con.Query<topics>("select * from topic").ToList();
            cb_topicname.DataSource = q2.ToList();
            cb_topicname.ValueMember = "top_id";
            cb_topicname.DisplayMember = "top_Name";

        }

        private void dgv_course_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = (int)dgv_course.SelectedRows[0].Cells[0].Value;
            var q2 = con.QueryFirstOrDefault<Course>("select c.*,T.top_name from course c inner join Topic T on c.top_id = t.top_id where c.Crs_id=@id", new { id });
            textname.Text = q2.Crs_Name;
            textduration.Text = q2.Crs_Duration.ToString();
            cb_topicname.SelectedValue = q2.Top_Id;
            //MessageBox.Show(id.ToString());


        }

        private void button1_Click(object sender, EventArgs e)
        {
            var q3 = con.QueryFirstOrDefault<Course>("insert into course values(@name, @duration, @topic)", new
            {
                name = textname.Text,
                duration = int.Parse(textduration.Text),
                topic = cb_topicname.SelectedValue
            });
            var q1 = con.Query<Course>("select c.*,T.top_name from course c inner join Topic T on c.top_id = t.top_id ");

            dgv_course.DataSource = q1.ToList();

            MessageBox.Show("ADDED");
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            var row = con.Execute("update course set Crs_Name=@name,Crs_duration= @duration,Top_ID= @top where Crs_Id =@id", new { id, name = textname.Text, duration = int.Parse(textduration.Text), top = cb_topicname.SelectedValue });
            var q1 = con.Query<Course>("select c.*,T.top_name from course c inner join Topic T on c.top_id = t.top_id ");

            dgv_course.DataSource = q1.ToList();
            MessageBox.Show("Updated");
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            var delq =con.Execute("delete from course where Crs_Id = @id", new { id });
            var q1 = con.Query<Course>("select c.*,T.top_name from course c inner join Topic T on c.top_id = t.top_id ");

            dgv_course.DataSource = q1.ToList();
            MessageBox.Show("Deleted");
        }
    }
}
