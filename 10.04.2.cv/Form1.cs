namespace _10._04._2.cv
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string msg1 = "Санкт-Петербургский государственный университетет, биолого-почвенный факультет, бакалавр по специальности Биология";
            string msg2 = "University of Auckland, New Zealand, Faculty of Science. Graduate Diploma of Science in Pure Mathematics";
            string msg3 = "Санкт-Петербургский государственный университетет, факультет прикладной математики, аспирантура по кафедре математического моделирования электромеханических и квантовых систем";
            double avg = (msg1.Length + msg2.Length + msg3.Length) / 3.0;
            MessageBox.Show(msg1);
            MessageBox.Show(msg2);
            MessageBox.Show(msg3, String.Format("{0}",avg));
        }
    }
}