using System.Media;

namespace SendDataToOtherForms_Video6_
{
    public partial class Form1 : Form
    {
        SoundPlayer ErrorSound = new SoundPlayer(@"D:\CSharp\WinFormsByLearningNeverEnds\SendDataToOtherForms(Video6)\SendDataToOtherForms(Video6)\off-hook-tone-43891-Trimed.wav");
        public static string Name;
        public static string RollNo;
        public static string Section;
        public static string Semester;
        public Form1()
        {
            InitializeComponent();
        }

        private void Send_button_Click(object sender, EventArgs e)
        {


            if (!string.IsNullOrEmpty(Name_textBox.Text))
            {
                if (!(Name_textBox.Text[0] >= 'A' && Name_textBox.Text[0] >= 'Z'))
                {
                    Name = Name_textBox.Text;
                }
                else
                {
                    ErrorSound.Play();
                    MessageBox.Show("First letter of the name should be capital!");
                }
                if (!string.IsNullOrEmpty(RollNo_textBox.Text))
                {
                    RollNo = RollNo_textBox.Text;
                    if (!string.IsNullOrEmpty(Section_textBox.Text))
                    {
                        Section = Section_textBox.Text;
                        if (!string.IsNullOrEmpty(Semester_textBox.Text))
                        {
                            Semester = Semester_textBox.Text;
                            Name_textBox.Clear();
                            RollNo_textBox.Clear();
                            Section_textBox.Clear();
                            Semester_textBox.Clear();
                            Form2 ResultantForm = new Form2();
                            ResultantForm.Show();
                        }
                        else
                        {
                            ErrorSound.Play();
                            MessageBox.Show("Enter Semester!");
                        }
                    }
                    else
                    {
                        ErrorSound.Play();
                        MessageBox.Show("Enter Section!");
                    }
                }
                else
                {
                    ErrorSound.Play();
                    MessageBox.Show("Enter Roll NO!");
                }
            }
            else
            {
                ErrorSound.Play();
                MessageBox.Show("Enter Name!");
            }
        }
    }
}
