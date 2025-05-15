using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Structure_Argument
{
    struct Automobile
    {
        public string make;
        public int year;
        public double mileage;
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // DisplayAuto 方法接受一個 Automobile 物件作為參數，並顯示其欄位。
        private void DisplayAuto(Automobile auto)
        {
            MessageBox.Show(
                auto.year + " 年 " + auto.make +
                "，里程數：" + auto.mileage + " 英里。"
            );
        }

        private void auto1Button_Click(object sender, EventArgs e)
        {
            // 建立一個 Automobile 結構的實例。
            Automobile sportsCar = new Automobile();

            // 指定物件欄位的值。
            sportsCar.make = "雪佛蘭 Corvette";
            sportsCar.year = 1970;
            sportsCar.mileage = 50000.0;

            // 顯示物件的欄位。
            DisplayAuto(sportsCar);
        }

        private void auto2Button_Click(object sender, EventArgs e)
        {
            // 建立一個 Automobile 結構的實例。
            Automobile pickupTruck = new Automobile();

            // 指定物件欄位的值。
            pickupTruck.make = "福特 Ranger";
            pickupTruck.year = 1985;
            pickupTruck.mileage = 75000.0;

            // 顯示物件的欄位。
            DisplayAuto(pickupTruck);
        }

        private void auto3Button_Click(object sender, EventArgs e)
        {
            // 建立一個 Automobile 結構的實例。
            Automobile sedan = new Automobile();

            // 指定物件欄位的值。
            sedan.make = "本田 Accord";
            sedan.year = 2000;
            sedan.mileage = 80000.0;

            // 顯示物件的欄位。
            DisplayAuto(sedan);
        }
    }
}
