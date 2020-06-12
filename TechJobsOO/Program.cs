using System;
using System.Collections.Generic;

namespace TechJobsOO
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Job job1 = new Job("Product tester", "ACME", "Desert", "Quality control", "Persistence");
            Job job2 = new Job("Web Developer", "LaunchCode", "St. Louis", "Front-end developer", "JavaScript");
            Job job3 = new Job("Ice cream tester", null, "Home", "UX", "Tasting ability");
            Job job4 = new Job(null , "ACME", "Home", "Product Tester", "Death wish");
            Job job5 = new Job();
            Job job6 = new Job("Potato Peeler", null, null, "Kitchen aide", "able to do a monotonous job over and over and over");

            List<Job> jobs = new List<Job>();

            jobs.Add(job1);
            jobs.Add(job2);
            jobs.Add(job3);
            jobs.Add(job4);
            jobs.Add(job5);
            jobs.Add(job6);

            foreach (Job job in jobs)
            {
                Console.WriteLine(job);
            }
        }
    }
}
