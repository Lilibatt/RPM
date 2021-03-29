using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPM
{
    public partial class SecondForm : Form
    {
        FirstForm frm;
        int Holidaynum;
        TimeSpan TimeSpan;
        DateTime TodayDate = DateTime.Now;
        DateTime Holiday;
        public SecondForm(FirstForm f, int holiday)
        {
            InitializeComponent();

            frm = f;
            Holidaynum = holiday;

            DateTime dtt = DateTime.Now;

            timer1.Enabled = true;

            switch (Holidaynum)
            {
                case 0:
                    {
                        HolName.Text = "Новый Год";
                        Holiday = new DateTime(dtt.Year, 1, 31);
                        break;
                    }
                case 1:
                    {
                        HolName.Text = "День Конституции";
                        Holiday = new DateTime(dtt.Year, 12, 12);
                        break;
                    }
                case 2:
                    {
                        HolName.Text = "День Корюшки";
                        Holiday = new DateTime(dtt.Year, 5, 19);
                        break;
                    }
                case 3:
                    {
                        HolName.Text = "День основания Санкт-Петербурга";
                        Holiday = new DateTime(dtt.Year, 5, 27);
                        break;
                    }
                case 4:
                    {
                        HolName.Text = "Мой День Рождения";
                        Holiday = new DateTime(dtt.Year, 9, 30);
                        break;
                    }
            }
        }

        private void SecondForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TodayDate = DateTime.Now;
            HolName.Visible = true;
            if ((Holiday.Subtract(TodayDate)).Days < 0)
            {
                Holiday = Holiday.AddYears(1);
            }
            TimeSpan = Holiday.Subtract(TodayDate);
            TimeLeft.Text = "Дни: " + TimeSpan.Days + "\nВремя: " + TimeSpan.Hours + ":" + TimeSpan.Minutes + ":" + TimeSpan.Seconds;
        }

        private void HolName_Click(object sender, EventArgs e)
        {

        }
    }
}
