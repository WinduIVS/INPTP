using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cv05Beehive
{
    public class Queen
    {
        private int shiftNumber = 0;
        Worker[] workers;

        public Queen(Worker[] workers)
        {
            this.workers = workers;
        }

        public bool AssignWork(string job, int numberOfShifts)
        {
            for (int i = 0; i < workers.Length; i++)
                if (workers[i].DoThisJob(job, numberOfShifts))
                    return true;
            return false;
        }


        public string WorkTheNextShift()
        {
            shiftNumber++;
            string report = "Report for Nr. " + shiftNumber + "\r\n";
            for (int i = 0; i < workers.Length; i++)
            {
                if (workers[i].WorkOneShift())
                    report += "Worker Nr." + (i + 1) + "finished the job\r\n";
                if(String.IsNullOrEmpty(workers[i].CurrentJob))
                    report += "Worker Nr." + (i + 1) + "nothing to do\r\n";


            }

            return report;
        }


    }
}
