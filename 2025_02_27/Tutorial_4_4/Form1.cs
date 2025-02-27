namespace Tutorial_4_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double distance, gas, average;  //�ŧi�ϰ��ܼ�
            if (double.TryParse(distancetextBox.Text, out distance))
            {
                if (double.TryParse(gastextBox.Text, out gas))
                {
                    average = distance / gas; //�p�⥭���o��
                    averageLabel.Text = average.ToString("f2") + "����/����";
                    logListBox.Items.Add(average.ToString("f2") + "����/����");
                }
                else
                {
                    MessageBox.Show("�o�ӽп�J�Ʀr");
                    gastextBox.Focus(); //�N���в���gastextBox
                    gastextBox.Text = ""; //�M��
                }
            }
            else
            {
                MessageBox.Show("�п�J�Ʀr");
                distancetextBox.Focus(); //�N���в���distancetextBox
                distancetextBox.Text = ""; //�M��
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close(); //��������
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            logListBox.Items.Clear();
            logListBox.Items.Add("�����o�Ӭ���:");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sum = 0;
            if (logListBox.Items.Count > 1)
            {
                for (int i = 1;i<logListBox.Items.Count;i++)
                {
                    sum += double.Parse(logListBox.Items[i].ToString().Replace("����/����", "")); //�֥[�����o��
                }
                logListBox.Items.Add("�����o��:"+(sum/(logListBox.Items.Count-1)).ToString("f2") + "����/����");
            }
            else
            {
                MessageBox.Show("�S������");
            }
        }
    }
}
