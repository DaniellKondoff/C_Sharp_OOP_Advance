using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsDemo
{
    public class StartUp
    {
        public delegate void WorkPerformedDelegate(int hours, WorkType type);
        public static void Main(string[] args)
        {
            //WorkPerformedDelegate dele = new WorkPerformedDelegate(WorkPerformed);

            //dele(5, WorkType.Exam);

            var worker = new Worker();
            worker.DoWork(7, WorkType.Sports);
        }

        public static void WorkPerformed(int hours, WorkType type)
        {
            Console.WriteLine("WorkPerfomerd for " + hours + " hours");
        }


    }

}
