using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagementWF_p._301
{
    class Worker : Bee
    {
        #region Fields, properties and constructors
        string[] _jobICanDo;
        private int ShiftsToWork;
        private int shiftsWorked;
        const double _honeyConsumptionPerShiftWorked = 0.65;

        public string CurrectJob { get; private set; } = "";
        public int ShiftsLeft { get => ShiftsToWork - shiftsWorked; }
        public Worker(string[] jobsICanDo, double weightMg) : base(weightMg)
        {
            _jobICanDo = jobsICanDo;
        }
        #endregion

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
        public override double HoneyConsumptionRate()
        {
            double consumption = base.HoneyConsumptionRate();
            consumption += shiftsWorked * _honeyConsumptionPerShiftWorked;
            return consumption;
        }
    }
}
