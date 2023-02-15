using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fridays
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            DateTime first = dateTimePicker1.Value.Date;
            DateTime last = dateTimePicker2.Value.Date;
            int first_y = first.Year;
            int last_y = last.Year;
            for (int year = first_y; year <= last_y; year++)
            {
                for (int month = 1; month <= 12; month++)
                {
                    DateTime test = new DateTime(year, month, 13);
                    if (test < first)
                        continue;
                    if (test > last)
                        break;
                    if (test.DayOfWeek == DayOfWeek.Friday)
                        listBox1.Items.Add(test.ToShortDateString());
                }
            }
        }
    }
}

