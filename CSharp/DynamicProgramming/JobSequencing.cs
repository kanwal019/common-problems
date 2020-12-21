/*
 * Given an array of jobs where every job has a deadline and associated profit if the job is finished before the deadline. It is also given that every job takes the single unit of time, so the minimum possible deadline for any job is 1. How to maximize total profit if only one job can be scheduled at a time
 * 
 * Reads input from the console -
 *  - First line contains the number of inputs
 *  - Each next line consist of comma seperated values -
 *      - Job ID
 *      - Deadline in 24 hr format
 *      - Profit
 * Return the sequence of Jobs in output
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp.DynamicProgramming
{
    internal class Job
    {
        public string JobId { get; set; }
        public int Deadline { get; set; }
        public int Profit { get; set; }
    }

    public class JobSequencing
    {
        private static List<string> MockData
        {
            get
            {
                return new List<string>
                {
                    "A, 13, 100",
                    "B, 18, 400",
                    "C, 13, 230",
                    "D, 18, 220",
                    "E, 13, 200",
                    "F, 13, 200",
                    "G, 18, 240",
                    "H, 18, 500",
                };
            }
        }

        public static void DisplayResult()
        {
            //int count = Convert.ToInt32(Console.ReadLine());
            List<Job> jobs = new List<Job>();
            Job job;

            for(int i = 0; i < MockData.Count; i++)
            {
                //var input = Console.ReadLine().Split(',');
                var input = MockData[i].Split(',');

                job = new Job()
                {
                    JobId = input[0].Trim(),
                    Deadline = Convert.ToInt32(input[1].Trim()),
                    Profit = Convert.ToInt32(input[2].Trim())
                };

                jobs.Add(job);
            }

            Console.WriteLine(SequenceJobs(jobs));
        }

        private static string SequenceJobs(List<Job> jobs)
        {
            var morningJobs = jobs.Where(job => job.Deadline == 13).OrderByDescending(job => job.Profit).Take(2).ToList();
            var noonJobs = jobs.Where(job => job.Deadline == 18).OrderByDescending(job => job.Profit).Take(2).ToList();

            return morningJobs[0].JobId + "-" + morningJobs[1].JobId + "-" + noonJobs[0].JobId + "-" + noonJobs[1].JobId;
        }
    }
}
