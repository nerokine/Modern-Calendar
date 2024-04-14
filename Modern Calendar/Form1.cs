using System;
using System.Globalization;
using System.Windows.Forms;

namespace Modern_Calendar
{
    public partial class Form1 : Form
    {
        int month, year;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            displayDays();
        }

        private void displayDays()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;

            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBDATE.Text = monthname + " " + year;

            DateTime startOfTheMonth = new DateTime(year, month, 1);

            int days = DateTime.DaysInMonth(year, month);

            int dayOfWeek = (int)startOfTheMonth.DayOfWeek;  

          
            for (int i = 0; i < dayOfWeek; i++)
            {
                UserControlBlank ucBlank = new UserControlBlank();
                ucBlank.Visible = true; 
                dayContainer.Controls.Add(ucBlank);
            }

            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucDays = new UserControlDays();
                ucDays.days(i); 
                dayContainer.Controls.Add(ucDays);
            }
        }

        private void btnprevious_Click(object sender, EventArgs e)
        {
            dayContainer.Controls.Clear();

            month--;

            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBDATE.Text = monthname + " " + year;

            DateTime startOfTheMonth = new DateTime(year, month, 1);

            int days = DateTime.DaysInMonth(year, month);

            int dayOfWeek = (int)startOfTheMonth.DayOfWeek;  
        
            for (int i = 0; i < dayOfWeek; i++)
            {
                UserControlBlank ucBlank = new UserControlBlank();
                ucBlank.Visible = true; 
                dayContainer.Controls.Add(ucBlank);
            }

         
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucDays = new UserControlDays();
                ucDays.days(i); 
                dayContainer.Controls.Add(ucDays);
            }
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            dayContainer.Controls.Clear();
            
            month++;

            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBDATE.Text = monthname + " " + year;

            DateTime startOfTheMonth = new DateTime(year, month, 1);

            int days = DateTime.DaysInMonth(year, month);

            int dayOfWeek = (int)startOfTheMonth.DayOfWeek;  

            
            for (int i = 0; i < dayOfWeek; i++)
            {
                UserControlBlank ucBlank = new UserControlBlank();
                ucBlank.Visible = true; 
                dayContainer.Controls.Add(ucBlank);
            }

            
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucDays = new UserControlDays();
                ucDays.days(i); 
                dayContainer.Controls.Add(ucDays);
            }
        }
    }
}
