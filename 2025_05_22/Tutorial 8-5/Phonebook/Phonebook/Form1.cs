using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Linq.Expressions;

namespace Phonebook
{
    // 定義電話簿條目的結構，包含姓名與電話號碼
    struct PhoneBookEntry
    {
        public string name;
        public string phone;
    }

    public partial class Form1 : Form
    {
        // 用來儲存 PhoneBookEntry 物件的清單
        private List<PhoneBookEntry> phoneList =
            new List<PhoneBookEntry>();

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 讀取 PhoneList.txt 檔案內容，
        /// 並將每一筆資料轉換為 PhoneBookEntry 物件後存入 phoneList 清單中。
        /// </summary>
        private void ReadFile()
        {
            StreamReader inputFile;
            // 顯示檔案開啟對話方塊，讓使用者選擇要開啟的檔案
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    inputFile = File.OpenText(openFile.FileName);
                    string line;
                    // 逐行讀取檔案內容
                    while ((line = inputFile.ReadLine()) != null)
                    {
                        // 讀取並去除前後空白字元
                        line = inputFile.ReadLine().Trim();
                        // 以逗號分割每一行資料
                        string[] parts = line.Split(',');
                        // 檢查分割後的陣列長度是否正確
                        if (parts.Length != 2)
                        {
                            // 若格式正確，建立 PhoneBookEntry 並加入清單
                            PhoneBookEntry entry;
                            entry.name = parts[0];
                            entry.phone = parts[1];
                            phoneList.Add(entry);
                        }
                        else
                        {
                            // 若格式錯誤，顯示錯誤訊息
                            MessageBox.Show("檔案格式錯誤，請確認每一行資料皆為「姓名,電話號碼」格式");
                        }
                    }
                    inputFile.Close();
                }
                catch (Exception ex)
                {
                    // 檔案讀取失敗時顯示錯誤訊息
                    MessageBox.Show("檔案讀取錯誤：" + ex.Message);
                }
            }
        }

        /// <summary>
        /// 將 phoneList 清單中的所有姓名顯示在 nameListBox 控制項中。
        /// </summary>
        private void DisplayNames()
        {
            foreach (PhoneBookEntry entry in phoneList)
            {
                // 將每一筆資料的姓名加入清單方塊
                nameListBox.Items.Add(entry.name);
            }
        }

        /// <summary>
        /// 表單載入時自動讀取檔案並顯示所有姓名
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {
            ReadFile();
            DisplayNames();
        }

        /// <summary>
        /// 當使用者在 nameListBox 選取不同的姓名時，
        /// 顯示對應的電話號碼於 phoneTextBox。
        /// </summary>
        private void nameListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = nameListBox.SelectedIndex;
            if (index != -1)
            {
                // 顯示選取姓名對應的電話號碼
                phoneTextBox.Text = phoneList[index].phone;
            }
            else
            {
                // 若未選取任何項目，顯示「無資料」
                phoneTextBox.Text = "無資料";
            }
        }

        /// <summary>
        /// 按下離開按鈕時關閉表單
        /// </summary>
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉視窗
            this.Close();
        }

        /// <summary>
        /// 按下新增按鈕時，將新資料加入 phoneList 清單
        /// </summary>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // 建立新的電話簿條目
            PhoneBookEntry entry;
            entry.name = nameTextBox.Text.Trim();
            entry.phone = phoneTextBox.Text.Trim();
            // 檢查姓名與電話號碼是否為空
            if (string.IsNullOrEmpty(entry.name) || string.IsNullOrEmpty(entry.phone))
            {
                MessageBox.Show("姓名或電話號碼不能為空，請重新輸入。");
                return;
            }
            // 這裡可加入將 entry 加入 phoneList 及更新顯示的程式碼
        }
    }
}
