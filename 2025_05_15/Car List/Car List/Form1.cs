using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_List
{
    struct Automobile
    {
        public string make;
        public int year;
        public double mileage;
    }

    public partial class Form1 : Form
    {
        // 建立一個 List 作為欄位，用來儲存汽車資料。
        private List<Automobile> carList = new List<Automobile>();

        public Form1()
        {
            InitializeComponent();

            // 設定所有元件的 Text 屬性為繁體中文
            this.Text = "汽車清單";
            carInfoGroupBox.Text = "汽車資訊";
            makePromptLabel.Text = "廠牌：";
            yearPromptLabel.Text = "年份：";
            mileagePromptLabel.Text = "里程數：";
            addButton.Text = "新增汽車";
            displayButton.Text = "顯示清單";
        }

        // GetData 方法取得使用者輸入的資料
        // 並指派給參數物件的欄位。
        private void GetData(ref Automobile auto)
        {
            try
            {
                // 從 TextBox 取得資料。
                auto.make = makeTextBox.Text;
                auto.year = int.Parse(yearTextBox.Text);
                auto.mileage = double.Parse(mileageTextBox.Text);
            }
            catch (Exception ex)
            {
                // 顯示例外訊息。
                MessageBox.Show(ex.Message);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            // 建立一個 Automobile 結構的實例。
            Automobile car = new Automobile();

            // 取得使用者輸入的資料。
            GetData(ref car);

            // 將汽車物件加入 List。
            carList.Add(car);

            // 清除所有 TextBox。
            makeTextBox.Clear();
            yearTextBox.Clear();
            mileageTextBox.Clear();

            // 重設游標焦點。
            makeTextBox.Focus();
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            // 宣告一個字串用來儲存每一行輸出。
            string output;

            // 清除 ListBox 目前的內容。
            carListBox.Items.Clear();

            // 在 ListBox 顯示所有汽車資訊。
            foreach (Automobile aCar in carList)
            {
                // 組合一行輸出字串。
                output = aCar.year + " 年 " + aCar.make +
                    "，里程數 " + aCar.mileage + " 英里。";

                // 將輸出字串加入 ListBox。
                carListBox.Items.Add(output);
            }
        }
    }
}
