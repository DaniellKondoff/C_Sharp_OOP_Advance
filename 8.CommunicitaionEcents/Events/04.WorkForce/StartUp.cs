using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class StartUp
{
    public delegate void JobDoneEventhandler(object sender, JobEventArgs e);

    static void Main(string[] args)
    {
        JobList jobs = new JobList();
        List<BaseEmployee> employees = new List<BaseEmployee>();

        string[] input = Console.ReadLine().Split();

        while(input[0] != "End")
        {
            switch (input[0])
            {
                case "Job":
                    Job realJob =new Job(input[1], int.Parse(input[2]), employees.FirstOrDefault(e => e.Name == input[3]));

                    realJob.JobDone += realJob.OnJobDone;
                    jobs.Add(realJob);
                    break;
                case "StandartEmployee":
                    BaseEmployee employee = new StandartEmployee(input[1]);
                    employees.Add(employee);
                    break;
                case "PartTimeEmployee":
                    BaseEmployee pTemployee = new PartTimeEmployee(input[1]);
                    employees.Add(pTemployee);
                    break;
                case "Pass":
                    foreach (var job in jobs)
                    {
                        job.Update();
                    }
                    break;
                case "Status":
                    foreach (var job in jobs)
                    {
                        if (!job.IsDone)
                        {
                            Console.WriteLine(job.ToString());

                        }
                    }
                    break;
            }

            input = Console.ReadLine().Split();
        }
    }
}

