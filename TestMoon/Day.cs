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
    public partial class Day : UserControl
    {
        public DateTime Date { get; set; }=new DateTime();
        public double LunarDay { get; set; } = 0;
        public string Imge { get; set; } = "";
        public double Lunar { get; set; } = 29.53058770576;
        public Day()
        {
            InitializeComponent();
        }
        public Day(DateTime Date,double lunar = 29.53058770576)
        {
            this.Date = Date;
            this.LunarDay = Calcul.LunarCalendar.GetLunarDay(this.Date, lunar);
            this.Imge = Application.StartupPath + "\\Resources\\" +  Calcul.LunarCalendar.GetImageNameFromIndex(this.LunarDay);
            this.pictureBox1.Image = System.Drawing.Image.FromFile(this.Imge);
            this.label1.Text = this.Date.ToShortDateString();
        }

        public void FormatMe(DateTime Date, double lunar  )
        {
            this.Date = Date;
            this.LunarDay = Calcul.LunarCalendar.GetLunarDay(this.Date, lunar);
            this.LunarDate.Text = this.LunarDay.ToString();
            this.Imge = Application.StartupPath + "\\Resources\\" + Calcul.LunarCalendar.GetImageNameFromIndex(this.LunarDay);
            if(this.LunarDay >= 0) { 
            this.pictureBox1.Image = System.Drawing.Image.FromFile(this.Imge);
            }
            this.label1.Text = this.Date.ToShortDateString();
        }
    }
}
