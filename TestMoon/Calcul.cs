using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMoon
{
    public class Calcul

    {   
        /// <summary>
         /// Va retourné le numéro de la semaine en fonction d'une date
         /// </summary>
         /// <param name="time"></param>
         /// <returns></returns>
        public static int GetIso8601WeekOfYear(DateTime time)
        {
            // Seriously cheat.  If its Monday, Tuesday or Wednesday, then it'll 
            // be the same week# as whatever Thursday, Friday or Saturday are,
            // and we always get those right
            DayOfWeek day = CultureInfo.InvariantCulture.Calendar.GetDayOfWeek(time);
            if (day >= DayOfWeek.Monday && day <= DayOfWeek.Wednesday)
            {
                time = time.AddDays(3);
            }

            // Return the week of our adjusted day
            return CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(time, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
        }
        public enum Mois
        {
            Janvier = 1,
            Février = 2,
            Mars = 3,
            Avril = 4,
            Mai = 5,
            Juin = 6,
            Juillet = 7,
            Août = 8,
            Septembre = 9,
            Octobre = 10,
            Novembre = 11,
            Décembre = 12
        }
        /// <summary>
        /// Définie un range temporelle 
        /// </summary>
        public class TimeRange
        {
            public string Header { get; set; } = "";
            public int Year { get { return Début.Year; } }
            public int WeekId { get { return Calcul.GetIso8601WeekOfYear(Début); } }
            public DateTime Début { get; set; } = new DateTime();
            public DateTime Fin { get; set; } = new DateTime();
            public int Days
            {
                get
                {
                    return Fin.Subtract(Début).Days;
                }
            }
        }
        public class LunarCalendar
        {
            #region Constante
            /*
             Pour calculer le calendrier lunaire, nous procéderons par calculer le temps d'une rotation lunaire autour de la terre.
             ref : https://en.wikipedia.org/wiki/Moon 
                    Orbital period (synodic)	29.530589 d (29 d 12 h 44 min 2.9 s)
                    En conversion numérique cela donne 29.530589 jours
             */
            public const double LunarPeriod = 29.5305877058; // donc ca prend 29 jours 12 heures, 44 minutes et 2.9 secondes à la lune pour faire le tour de la terre.
            public static DateTime NewMoon2022 = new DateTime(2022, 1, 2,19,33,0); //première nouvelle lune de l'année 2022 comme référence.
            #endregion
            /// <summary>
            /// Retourne une date en lunaire phase
            /// </summary>
            /// <param name="Date"></param>
            /// <returns></returns>
            public static MoonPhases GetMoonPhases(DateTime Date, double Lunar)
            {
                MoonPhases Result = MoonPhases.NewMoon;
                var LunarDay = GetLunarDay(Date,Lunar);
                if (LunarDay > 0 && LunarDay <= 1)
                {
                    Result = MoonPhases.NewMoon;
                }
                else if (LunarDay > 1 && LunarDay <= (double)6.382647)
                {
                    Result = MoonPhases.WaxingCrescent;
                }
                else if (LunarDay > (double)6.382647 && LunarDay <= (double)8.382647)
                {
                    Result = MoonPhases.FirsQuarter;
                }
                else if (LunarDay > (double)8.382647 && LunarDay <= (double)13.765294)
                {
                    Result = MoonPhases.WaxingGibbous;
                }
                else if (LunarDay > (double)13.765294 && LunarDay <= (double)15.765294)
                {
                    Result = MoonPhases.FullMoon;
                }
                else if (LunarDay > (double)15.765294 && LunarDay <= (double)21.147941)
                {
                    Result = MoonPhases.WaningGibbous;
                }
                else if (LunarDay > (double)21.147941 && LunarDay <= (double)23.147941)
                {
                    Result = MoonPhases.LastQuarter;
                }
                else if (LunarDay > (double)23.147941 && LunarDay <= (double)28.530588)
                {
                    Result = MoonPhases.WaningCrescent;
                }
                else if (LunarDay > (double)28.530588 && LunarDay <= (double)29.530588)
                {
                    Result = MoonPhases.NewMoon;
                }
                return Result;
            }
            public static int GetImageIndexFromDate(DateTime Date,double lunar)
            {
                double LunarDay = GetLunarDay(Date,lunar);
                return (int)LunarDay;
            }
            public static string GetImageNameFromIndex(double LunarDay)
            {
                if (LunarDay > 2 && LunarDay <10)
                {
                    LunarDay = LunarDay - 1;
                }
                else if(LunarDay >= 10)
                {
                    LunarDay = LunarDay - 2;
                }
                int LunarDayint = 0;
                double Decimal = 0;

                if ((int)LunarDay <= 1)
                {
                    if (LunarDay > 1)
                    {
                        LunarDayint = 1;
                    }
                    else
                    {
                        LunarDayint = 0;
                    }
                }
                if ((int)LunarDay >= 29)
                {
                    LunarDayint = 0;
                }
                else if ((int)LunarDay == 28)
                {
                    LunarDayint = 28;
                }
                else
                {
                    Decimal = LunarDay - (int)LunarDay;
                    LunarDayint = (int)LunarDay;
                    if (Decimal > 0.5)
                    {
                        LunarDayint += 1;
                    }
                }
                string Result = "";
                if (LunarDayint < 10)
                {
                    Result += "Moon_0" + LunarDayint + ".png";
                }
                else
                {
                    Result += "Moon_" + LunarDayint + ".png";
                }
                return Result;
            }
            public static double GetLunarDay(DateTime Date, double Lunar)
            {
                var Diff = Date.Subtract(NewMoon2022).Days;
                return (Diff % Lunar) ;
            }

            public static DateTime GetNewMoonFromPeriod(Mois Month, int Year, double Lunar= 29.53058770576)
            {
                TimeRange Range = new TimeRange();
                Range.Début = new DateTime(Year, (int)Month, 1);
                Range.Fin = new DateTime(Year, (int)Month, DateTime.DaysInMonth(Year, (int)Month));
                DateTime Result = new DateTime();
                for (int i = 0; i < Result.Day; i++)
                {
                    var Phase = GetMoonPhases(Range.Début.AddDays(i), Lunar);
                    if (Phase == MoonPhases.NewMoon)
                    {
                        Result = new DateTime(Year, (int)Month, i);
                        break;
                    }
                }
                return Result;
            }
            public enum MoonPhases
            {
                /// <summary>
                /// 0 < lunar day <= 1
                /// or
                /// 28.530588 < lunar day <= 29.530588
                /// </summary>
                NewMoon = 0,
                /// <summary>
                /// 1 < lunar day <= 6.382647
                /// </summary>
                WaxingCrescent = 1,
                /// <summary>
                /// 6.382647 < lunar day <= 8.382647
                /// </summary>
                FirsQuarter = 2,
                /// <summary>
                /// 8.382647 < lunar day <= 13.765294
                /// </summary>
                WaxingGibbous = 3,
                /// <summary>
                /// 13.765294 < lunar day <= 15.765294
                /// </summary>
                FullMoon = 4,
                /// <summary>
                /// 15.765294 < lunar day <= 21.147941
                /// </summary>
                WaningGibbous = 5,
                /// <summary>
                /// 21.147941 < lunar day <= 23.147941
                /// </summary>
                LastQuarter = 6,
                /// <summary>
                /// 23.147941 < lunar day <= 28.530588
                /// </summary>
                WaningCrescent = 7,
            }
        }
    }
}
