using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cv05Beehive
{
    public class Worker
    {
        private string[] jobsICanDo;
        private int shiftsToWork;
        private int shiftsWorked;

        private string currentJob = "";
        public string CurrentJob
        {
            get
            {
                return currentJob;
            }
        }
      
        

        public int ShiftsLeft
        {
            get
            {
                return shiftsToWork - shiftsWorked;
            }
        }

        public Worker(string[] jobsICanDo)
        {
            this.jobsICanDo = jobsICanDo;
        }

        public bool DoThisJob(string job, int numberOfShifts)
        {
            if (!String.IsNullOrEmpty(currentJob))
                return false;
            for (int i= 0; i < jobsICanDo.Length;i++)
                if (jobsICanDo[i] == job)
                {
                    currentJob = job;
                    shiftsToWork = numberOfShifts;
                    shiftsWorked = 0;
                    return true;
                }
            return false;
        }
        public bool WorkOneShift()
        {
            if (String.IsNullOrEmpty(currentJob))
                return false;
            
            shiftsWorked++;

            if (shiftsWorked > shiftsToWork)
            {
                currentJob = "";
                shiftsToWork = 0;
                shiftsWorked = 0;

                return true;
            }

            return false;
        }

    }
}
     