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
            string msg1 = "�����-������������� ��������������� �������������, �������-��������� ���������, �������� �� ������������� ��������";
            string msg2 = "University of Auckland, New Zealand, Faculty of Science. Graduate Diploma of Science in Pure Mathematics";
            string msg3 = "�����-������������� ��������������� �������������, ��������� ���������� ����������, ����������� �� ������� ��������������� ������������� ������������������� � ��������� ������";
            double avg = (msg1.Length + msg2.Length + msg3.Length) / 3.0;
            MessageBox.Show(msg1);
            MessageBox.Show(msg2);
            MessageBox.Show(msg3, String.Format("{0}",avg));
        }
    }
}