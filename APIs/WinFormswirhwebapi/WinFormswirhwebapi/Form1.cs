namespace WinFormswirhwebapi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage resp = client.GetAsync("https://localhost:7070/api/Course").Result;
            if (resp.IsSuccessStatusCode)
            {
                List<Course> courses = resp.Content.ReadAsAsync<List<Course>>().Result;
                dataGridView1.DataSource = courses;
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Course course = new Course()
            {
                crs_name = text_name.Text,
                crs_desc = richText_desc.Text,
                duration = int.Parse(text_duration.Text)

            };
            HttpClient client = new HttpClient();
         HttpResponseMessage addresp = client.PostAsJsonAsync("https://localhost:7070/api/Course", course).Result;
            if (addresp.IsSuccessStatusCode)
            {
                Form1_Load(null, null);
                text_name.Text = text_duration.Text = richText_desc.Text = "";
                MessageBox.Show("Added Successfully ! ");
            }
        }
    }
}
