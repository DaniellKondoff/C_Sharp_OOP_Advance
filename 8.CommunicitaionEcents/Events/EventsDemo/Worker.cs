using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsDemo
{
    public class Worker
    {
        public delegate void WorkPerformedDelegate(int hours, WorkType type);

        public event WorkPerformedDelegate WorkPerformed;
        public event EventHandler WorkCompleted;

        public Worker()
        {
            WorkPerformed += OnWorkPerformed;
            WorkCompleted += OnWorkCompleted;
        }

        private void OnWorkCompleted(object sender, EventArgs e)
        {
            WorkCompletedEventArgs args = e as WorkCompletedEventArgs;
            Console.WriteLine(args.WorkType + " is done!");
        }

        protected void OnWorkPerformed(int hours, WorkType type)
        {
            Console.WriteLine("Work Performed " + hours);
        }

        public void DoWork(int hours,WorkType type)
        {
            for (int i = 0; i < hours; i++)
            {
                if (WorkPerformed != null)
                {
                    WorkPerformed.Invoke(i + 1, type);
                }
            }
            if (WorkCompleted != null)
            {
                WorkCompleted.Invoke(this, new WorkCompletedEventArgs(hours, type));
            }
        }

    }
}
