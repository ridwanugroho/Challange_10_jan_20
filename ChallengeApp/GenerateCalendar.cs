// ========================================================
// Generate calendar based on current month
// ========================================================
//
// Expected result
//   Januari 2020
//   S    S    R    K    J    S    M
//             1    2    3    4    5
//   6    7    8    9    10   11   12
//   13   14   15   16   17   18   19
//   20   21   22   23   24   25   26
//   27   28   29   30   31
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ChallengeApp
{
    public class GenerateCalendar
    {
        public static string createTable(string time)
        {
            var ci = new CultureInfo("id-ID");
            DateTime dt = DateTime.Parse("1 " + time, ci);
            int totDay = DateTime.DaysInMonth(dt.Year, dt.Month);
            int batas = 0;
            string ret = "S    S    R    K    J    S    M\n";
            var days = new Dictionary<string, int>()
            {
                {"Monday", 0},
                {"Tuesday", 1},
                {"Wednesday", 2},
                {"Thursday", 3},
                {"Friday", 4},
                {"Saturday", 5},
                {"Sunday", 6},
            };

            int startingDay = 0;
            // Console.WriteLine("jumlah hari : {0}", totDay);

            foreach (var day in days)
            {
                if(dt.ToString("dddd") == day.Key)
                    startingDay = day.Value;
            }

            // Console.WriteLine(startingDay);
            // Console.WriteLine("S    S    R    K    J    S    M");

            for(int i=0; i<5; i++)
            {
                for(int j=0; j<7; j++)
                {
                    if(batas == totDay)
                        goto end;

                    if(i==0 && j==0)
                    {
                        j = startingDay;
                        // Console.Write(printSpace(j));
                        ret += printSpace(j);
                    }

                    ret += Convert.ToString(batas+1).PadRight(2, ' ') + "   ";
                    // Console.Write("{0:00}   ", batas+1);
                    batas++;
                }

                // Console.WriteLine();
                ret += '\n';
            }

            // Console.WriteLine();

            end:
            return ret;
        }

        public static string printSpace(int n)
        {
            string temp = "     ";
            string ret = "";
            for(int i=0; i<n; i++)
                ret += temp;

            return ret;
        }
    }
}
