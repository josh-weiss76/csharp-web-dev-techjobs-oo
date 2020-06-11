﻿using System;

namespace TechJobsOO
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Job job1 = new Job("Product tester", "ACME", "Desert", "Quality control", "Persistence");
            Console.WriteLine(job1);

            /*Job job2 = new Job("Web Developer", new Employer("LaunchCode"), new Location("St. Louis"), new PositionType("Front-end developer"), new CoreCompetency("JavaScript"));
            Job job3 = new Job("Ice cream tester", new Employer(""), new Location("Home"), new PositionType("UX"), new CoreCompetency("Tasting ability"));

            List<Job> jobs = new List<Job>();

            jobs.Add(job1);
            jobs.Add(job2);
            jobs.Add(job3);

            foreach (Job job in jobs)
            {
                Console.WriteLine(job);
            }
            */
            Job newJob = new Job();
            Job otherJob = new Job();
            Console.WriteLine(newJob.Id);
            Console.WriteLine(otherJob.Id);
            Employer newEmployer = new Employer("Acme");
            Console.WriteLine(newEmployer.Value);
        }
    }
}
