using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateFunct
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime d1 = dateTimePicker1.Value;
            string s1 = d1.ToLongDateString();
            MessageBox.Show(s1);

            DateTime d2 = DateTime.Parse(s1);
            //dateTimePicker2.Value = d2;
            //DateTime d3 = DateTime.Parse("12.12.2019");
            //DateTime d4 = DateTime.Parse("12.12.2019");
            //int sonuc = d3.CompareTo(d4);
            //MessageBox.Show(sonuc.ToString());

            //DateTime d5 = dateTimePicker1.Value;
            //DateTime d6 = dateTimePicker2.Value;
            //int result = d5.CompareTo(d6);
            //MessageBox.Show(result.ToString());

            //DateTime d7 = dateTimePicker1.Value;
            //int result2 = d5.CompareTo(DateTime.Now);
            //MessageBox.Show(result2.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //DateTime da = dateTimePicker1.Value;
            //int sonuc = DateTime.DaysInMonth(da.Year, da.Month);
            //MessageBox.Show(sonuc.ToString());

            int sonuc = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
            MessageBox.Show(sonuc.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DateTime dateBirth = DateTime.Parse("09.05.1997 23:00:00");
            DateTime dateToday = DateTime.Now;
            TimeSpan ts = dateToday.Subtract(dateBirth);
            MessageBox.Show(ts.Days.ToString() + " day " + ts.Hours.ToString() + " Hour " +
                ts.Minutes.ToString() + " Minutes " + ts.Seconds.ToString() + " Seconds ");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //    DateTime newDate = DateTime.Now.AddDays(45);
            //    MessageBox.Show(newDate.ToString("dd.MM.yyyy hh:mm:ss tt"));

            DateTime d = DateTime.Parse("20.12.2019");
            DateTime newd = d.AddDays(3);
            MessageBox.Show(newd.ToString("dd.MM.yyyy"));

        }

        private void button5_Click(object sender, EventArgs e)
        {
            DateTime newDate = dateTimePicker1.Value.AddDays(30);
            //MessageBox.Show(newDate.DayOfWeek.ToString());
            if(newDate.DayOfWeek.ToString()=="Saturday")
            {
                newDate= newDate.AddDays(2);
            }
            else if (newDate.DayOfWeek.ToString() == "Sunday")
            {
                newDate = newDate.AddDays(1);
            }
            MessageBox.Show(newDate.DayOfWeek.ToString());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DateTime d1 = DateTime.Now;
            MessageBox.Show(d1.DayOfYear.ToString());
            MessageBox.Show(d1.ToString("dd-MM-yyyy"));
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double Value = Convert.ToDouble(textBox1.Text);
            string MAAS = String.Format("{0:c}", Value);
            MessageBox.Show(MAAS);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DateTime dtime1 = DateTime.Parse("14.07.2011");
            DateTime dtime2 = DateTime.Parse("14.08.2011");
            int result = DateTime.Compare(dtime1, dtime2);
            MessageBox.Show(result.ToString());
        }
    }
}
