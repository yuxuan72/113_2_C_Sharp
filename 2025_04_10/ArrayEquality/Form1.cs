namespace ArrayEquality
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] array1 = { 1, 2, 3, 4, 5 };
            int[] array2 = { 1, 2, 3, 4, 5 };

            //�ˬd��Ӱ}�C�O�_�۵�
            bool arraysEqual = isArraysEqual(array1, array2);
            if (arraysEqual)
            {
                MessageBox.Show("��Ӱ}�C�۵�");
            }
            else
            {
                MessageBox.Show("��Ӱ}�C���۵�");
            }
        }
        private bool isArraysEqual(int[] array1, int[] array2)
        {
            //�ˬd�}�C���׬O�_�۵�
            if (array1.Length != array2.Length)
            {
                return false;
            }
            //�ˬd�C�Ӥ����O�_�۵�
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] != array2[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
