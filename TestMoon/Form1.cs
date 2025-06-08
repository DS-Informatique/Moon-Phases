using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestMoon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Hideit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = Calcul.LunarCalendar.GetLunarDay(Input_Date.Value,(double)LunarPeriode.Value).ToString();

            Delta.Value = Input_Date.Value.Subtract(NewMoon2022.Value).Days;
            Modulo.Value = (Delta.Value % LunarPeriode.Value);
           Result.Value=(int)Modulo.Value;
            MapThisMonth(Input_Date.Value.Year, Input_Date.Value.Month);
        }
        int Month = 1;
        int Year = 0;
        public void Hideit()
        {
            week1day1.Visible = false;
            week1day2.Visible = false;
            week1day3.Visible = false;
            week1day4.Visible = false;
            week1day5.Visible = false;
            week1day6.Visible = false;
            week1day7.Visible = false;

            Week2day1.Visible = false;
            Week2day2.Visible = false;
            Week2day3.Visible = false;
            Week2day4.Visible = false;
            Week2day5.Visible = false;
            Week2day6.Visible = false;
            Week2day7.Visible = false;

            Week3day1.Visible = false;
            Week3day2.Visible = false;
            Week3day3.Visible = false;
            Week3day4.Visible = false;
            Week3day5.Visible = false;
            Week3day6.Visible = false;
            Week3day7.Visible = false;

            Week4day1.Visible = false;
            Week4day2.Visible = false;
            Week4day3.Visible = false;
            Week4day4.Visible = false;
            Week4day5.Visible = false;
            Week4day6.Visible = false;
            Week4day7.Visible = false;

            Week5day1.Visible = false;
            Week5day2.Visible = false;
            Week5day3.Visible = false;
            Week5day4.Visible = false;
            Week5day5.Visible = false;
            Week5day6.Visible = false;
            Week5day7.Visible = false;
        }
        public void MapThisMonth(int year, int month)
        {
            int Min = 1;
            int Max = DateTime.DaysInMonth(year, month);
            DateTime Start = new DateTime(year, month, 1);
            DateTime Clear = new DateTime(2000,1,1);
            if (Start.Month == 1)
            {
                Clear.AddMonths(1);
            }
            if (Start.DayOfWeek == DayOfWeek.Monday)
            {
                week1day1.FormatMe(Start,(double)this.LunarPeriode.Value);
                int i = 1;
                week1day2.FormatMe(Start.AddDays(i),(double)this.LunarPeriode.Value);i = i + 1;
                week1day3.FormatMe(Start.AddDays(i),(double)this.LunarPeriode.Value); i = i + 1;
                week1day4.FormatMe(Start.AddDays(i),(double)this.LunarPeriode.Value); i = i + 1;
                week1day5.FormatMe(Start.AddDays(i),(double)this.LunarPeriode.Value); i = i + 1;
                week1day6.FormatMe(Start.AddDays(i),(double)this.LunarPeriode.Value); i = i + 1;
                week1day7.FormatMe(Start.AddDays(i),(double)this.LunarPeriode.Value); i = i + 1;

                Week2day1.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week2day2.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week2day3.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week2day4.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week2day5.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week2day6.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week2day7.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;


                Week3day1.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week3day2.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week3day3.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week3day4.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week3day5.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week3day6.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week3day7.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;


                Week4day1.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week4day2.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week4day3.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week4day4.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week4day5.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week4day6.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week4day7.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;


                Week5day1.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week5day2.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week5day3.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week5day4.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week5day5.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week5day6.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week5day7.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
            }
            else if (Start.DayOfWeek == DayOfWeek.Tuesday)
                {
                 week1day1.FormatMe(Clear, (double)this.LunarPeriode.Value);
                week1day2.FormatMe(Start, (double)this.LunarPeriode.Value); int i = 1;
                week1day3.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                week1day4.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                week1day5.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                week1day6.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                week1day7.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;

                Week2day1.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week2day2.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week2day3.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week2day4.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week2day5.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week2day6.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week2day7.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;


                Week3day1.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week3day2.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week3day3.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week3day4.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week3day5.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week3day6.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week3day7.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;


                Week4day1.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week4day2.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week4day3.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week4day4.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week4day5.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week4day6.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week4day7.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;


                Week5day1.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week5day2.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week5day3.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week5day4.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week5day5.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week5day6.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week5day7.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
            }
            else if (Start.DayOfWeek == DayOfWeek.Wednesday)
            {
                  week1day1.FormatMe(Clear, (double)this.LunarPeriode.Value);
                week1day2.FormatMe(Clear, (double)this.LunarPeriode.Value);
                week1day3.FormatMe(Start, (double)this.LunarPeriode.Value); int i = 1;
                week1day4.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                week1day5.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                week1day6.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                week1day7.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;

                Week2day1.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week2day2.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week2day3.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week2day4.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week2day5.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week2day6.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week2day7.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;


                Week3day1.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week3day2.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week3day3.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week3day4.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week3day5.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week3day6.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week3day7.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;


                Week4day1.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week4day2.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week4day3.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week4day4.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week4day5.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week4day6.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week4day7.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;


                Week5day1.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week5day2.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week5day3.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week5day4.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week5day5.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week5day6.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week5day7.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
            }
            else if (Start.DayOfWeek == DayOfWeek.Thursday)
            {
               week1day1.FormatMe(Clear, (double)this.LunarPeriode.Value);
               week1day2.FormatMe(Clear, (double)this.LunarPeriode.Value); 
                week1day3.FormatMe(Clear, (double)this.LunarPeriode.Value);  
                week1day4.FormatMe(Start, (double)this.LunarPeriode.Value); int i = 1;
                week1day5.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                week1day6.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                week1day7.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;

                Week2day1.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week2day2.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week2day3.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week2day4.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week2day5.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week2day6.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week2day7.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;


                Week3day1.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week3day2.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week3day3.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week3day4.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week3day5.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week3day6.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week3day7.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;


                Week4day1.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week4day2.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week4day3.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week4day4.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week4day5.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week4day6.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week4day7.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;


                Week5day1.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week5day2.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week5day3.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week5day4.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week5day5.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week5day6.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week5day7.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
            }
            else if (Start.DayOfWeek == DayOfWeek.Friday)
            {
                week1day1.FormatMe(Clear, (double)this.LunarPeriode.Value);
                week1day2.FormatMe(Clear, (double)this.LunarPeriode.Value);
                week1day3.FormatMe(Clear, (double)this.LunarPeriode.Value);
                week1day4.FormatMe(Clear, (double)this.LunarPeriode.Value);
                week1day5.FormatMe(Start, (double)this.LunarPeriode.Value); int i = 1;
                week1day6.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                week1day7.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;

                Week2day1.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week2day2.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week2day3.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week2day4.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week2day5.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week2day6.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week2day7.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;


                Week3day1.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week3day2.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week3day3.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week3day4.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week3day5.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week3day6.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week3day7.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;


                Week4day1.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week4day2.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week4day3.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week4day4.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week4day5.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week4day6.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week4day7.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;


                Week5day1.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week5day2.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week5day3.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week5day4.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week5day5.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week5day6.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week5day7.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
            }
            else if (Start.DayOfWeek == DayOfWeek.Saturday)
            {
                week1day1.FormatMe(Clear, (double)this.LunarPeriode.Value);
                week1day2.FormatMe(Clear, (double)this.LunarPeriode.Value);
                week1day3.FormatMe(Clear, (double)this.LunarPeriode.Value);
                week1day4.FormatMe(Clear, (double)this.LunarPeriode.Value);
                week1day5.FormatMe(Clear, (double)this.LunarPeriode.Value);
                week1day6.FormatMe(Start, (double)this.LunarPeriode.Value); int i = 1;
                week1day7.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;

                Week2day1.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week2day2.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week2day3.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week2day4.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week2day5.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week2day6.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week2day7.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;


                Week3day1.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week3day2.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week3day3.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week3day4.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week3day5.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week3day6.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week3day7.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;


                Week4day1.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week4day2.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week4day3.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week4day4.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week4day5.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week4day6.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week4day7.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;


                Week5day1.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week5day2.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week5day3.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week5day4.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week5day5.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week5day6.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week5day7.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
            }
            else if (Start.DayOfWeek == DayOfWeek.Sunday)
            {
                week1day1.FormatMe(Clear, (double)this.LunarPeriode.Value);
                week1day2.FormatMe(Clear, (double)this.LunarPeriode.Value);
                week1day3.FormatMe(Clear, (double)this.LunarPeriode.Value);
                week1day4.FormatMe(Clear, (double)this.LunarPeriode.Value);
                week1day5.FormatMe(Clear, (double)this.LunarPeriode.Value);
                week1day6.FormatMe(Clear, (double)this.LunarPeriode.Value);
                week1day7.FormatMe(Start, (double)this.LunarPeriode.Value); int i = 1;

                Week2day1.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week2day2.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week2day3.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week2day4.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week2day5.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week2day6.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week2day7.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;


                Week3day1.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week3day2.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week3day3.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week3day4.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week3day5.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week3day6.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week3day7.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;


                Week4day1.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week4day2.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week4day3.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week4day4.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week4day5.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week4day6.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week4day7.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;


                Week5day1.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week5day2.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week5day3.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week5day4.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week5day5.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week5day6.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
                Week5day7.FormatMe(Start.AddDays(i), (double)this.LunarPeriode.Value); i = i + 1;
            }

            Hideit();

            if (week1day1.Date.Month==month && week1day1.Date.Year==year){ week1day1.Visible = true; }
            if(week1day2.Date.Month== month && week1day2.Date.Year == year) { week1day2.Visible = true; }
            if(week1day3.Date.Month== month && week1day3.Date.Year == year) { week1day3.Visible = true; }
            if(week1day4.Date.Month== month && week1day4.Date.Year == year) { week1day4.Visible = true; }
            if(week1day5.Date.Month== month && week1day5.Date.Year == year) { week1day5.Visible = true; }
            if(week1day6.Date.Month== month && week1day6.Date.Year == year) { week1day6.Visible = true; }
            if(week1day7.Date.Month== month && week1day7.Date.Year == year) { week1day7.Visible = true; }

            if (Week2day1.Date.Month == month) { Week2day1.Visible = true; }
            if (Week2day2.Date.Month == month) { Week2day2.Visible = true; }
            if (Week2day3.Date.Month == month) { Week2day3.Visible = true; }
            if (Week2day4.Date.Month == month) { Week2day4.Visible = true; }
            if (Week2day5.Date.Month == month) { Week2day5.Visible = true; }
            if (Week2day6.Date.Month == month) { Week2day6.Visible = true; }
            if (Week2day7.Date.Month == month) { Week2day7.Visible = true; }

            if (Week3day1.Date.Month == month) { Week3day1.Visible = true; }
            if (Week3day2.Date.Month == month) { Week3day2.Visible = true; }
            if (Week3day3.Date.Month == month) { Week3day3.Visible = true; }
            if (Week3day4.Date.Month == month) { Week3day4.Visible = true; }
            if (Week3day5.Date.Month == month) { Week3day5.Visible = true; }
            if (Week3day6.Date.Month == month) { Week3day6.Visible = true; }
            if (Week3day7.Date.Month == month) { Week3day7.Visible = true; }

            if (Week4day1.Date.Month == month && Week4day1.Date.Year == year) { Week4day1.Visible = true; }
            if (Week4day2.Date.Month == month && Week4day2.Date.Year == year) { Week4day2.Visible = true; }
            if (Week4day3.Date.Month == month && Week4day3.Date.Year == year) { Week4day3.Visible = true; }
            if (Week4day4.Date.Month == month && Week4day4.Date.Year == year) { Week4day4.Visible = true; }
            if (Week4day5.Date.Month == month && Week4day5.Date.Year == year) { Week4day5.Visible = true; }
            if (Week4day6.Date.Month == month && Week4day6.Date.Year == year) { Week4day6.Visible = true; }
            if (Week4day7.Date.Month == month && Week4day7.Date.Year == year) { Week4day7.Visible = true; }

            if (Week5day1.Date.Month == month && Week5day1.Date.Year == year) { Week5day1.Visible = true; }
            if (Week5day2.Date.Month == month && Week5day2.Date.Year == year) { Week5day2.Visible = true; }
            if (Week5day3.Date.Month == month && Week5day3.Date.Year == year) { Week5day3.Visible = true; }
            if (Week5day4.Date.Month == month && Week5day4.Date.Year == year) { Week5day4.Visible = true; }
            if (Week5day5.Date.Month == month && Week5day5.Date.Year == year) { Week5day5.Visible = true; }
            if (Week5day6.Date.Month == month && Week5day6.Date.Year == year) { Week5day6.Visible = true; }
            if (Week5day7.Date.Month == month && Week5day7.Date.Year == year) { Week5day7.Visible = true; }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            Input_Date.Value= Input_Date.Value.AddDays(1);
            button1.PerformClick();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Input_Date.Value = Input_Date.Value.AddDays(-1);
            button1.PerformClick();
        }
    }
}
