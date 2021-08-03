using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace JobReportProcess
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Timers.Timer aTimer = new System.Timers.Timer();
            aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            aTimer.Interval = 2000;
            aTimer.Enabled = true;
            Console.WriteLine("Press Any key to exit ....");
            Console.ReadKey();
        }

        private static void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            DataProcess.ExecuteJob();
            //Console.WriteLine("Proses lagi");
        }
    }
}
