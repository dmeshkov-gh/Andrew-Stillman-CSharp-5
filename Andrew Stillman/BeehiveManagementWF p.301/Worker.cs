using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagementWF_p._301
{
    class Worker
    {
        string[] _jobICanDo;
        private int ShiftsToWork;
        private int shiftsWorked;
        public string CurrectJob { get; private set; } = "";
        public int ShiftsLeft { get => ShiftsToWork - shiftsWorked; }
        public Worker(string[] jobsICanDo)
        {
            _jobICanDo = jobsICanDo;
        }

        internal bool DoThisJob(string job, int shifts)
        {
            if (!String.IsNullOrEmpty(CurrectJob))
                return false;
            for(int i = 0; i < _jobICanDo.Length; i++)
            {
                if(_jobICanDo[i] == job)
                {
                    CurrectJob = job;
                    ShiftsToWork = shifts;
                    shiftsWorked = 0;
                    return true;
                } 
            }
            return false;
        }

        internal bool DidYouFinish()
        {
            if (String.IsNullOrEmpty(CurrectJob))
                return false;
            shiftsWorked++;
            if(ShiftsLeft == 0)
            {
                shiftsWorked = 0;
                ShiftsToWork = 0;
                CurrectJob = "";
                return true;
            }
            return false;
        }
    }
}
