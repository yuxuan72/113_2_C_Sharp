using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lottery_Numbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            const int SIZE = 5; // The size of the array.
            int[] lotteryNumbers = new int[SIZE]; // Array to hold the numbers.
            Random rand = new Random(); // Random object.

            for (int i = 0; i < lotteryNumbers.Length; i++)
            {
                //產生1到42之間的亂數(包含1和42)，確認產生的亂數沒有與陣列中的數字重複，再放入陣列中
                int number;
                do
                {
                    number = rand.Next(1, 43); // /產生1到42之間的亂數
                } while (lotteryNumbers.Contains(number)); // 檢查是否已存在於陣列中
                lotteryNumbers[i] = number; // 將隨機數字放入陣列中
            }

            //將lotteryNumbers陣列中的數字由小到大排序
            Array.Sort(lotteryNumbers);// 將陣列中的數字由小到大排序


            //註解掉的原始程式碼，逐一將樂透號碼顯示在對應的標籤上
            //firstLabel.Text = lotteryNumbers[0].ToString();
            //secondLabel.Text = lotteryNumbers[1].ToString();
            //thirdLabel.Text = lotteryNumbers[2].ToString();
            //fourthLabel.Text = lotteryNumbers[3].ToString();
            //fifthLabel.Text = lotteryNumbers[4].ToString();

            //使用迴圈顯示樂透號碼
            Label[] showlabels = { firstLabel, secondLabel, thirdLabel, fourthLabel, fifthLabel };
            for (int i = 0; i < showlabels.Length; i++)
            {
                showlabels[i].Text = lotteryNumbers[i].ToString();
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
