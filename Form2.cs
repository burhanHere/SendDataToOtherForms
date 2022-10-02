namespace SendDataToOtherForms_Video6_
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Name_label.Text = Form1.Name;
            RollNo_label.Text = Form1.RollNo;
            Section_label.Text = Form1.Section;
            Semester_label.Text = Form1.Semester;
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Close();
            }
        }
    }
}
