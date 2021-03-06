﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagementWF_p._301
{
    class Queen : Bee
    {
        #region Fields, properties and constructors
        Worker[] _myWorkers;
        int shiftNumber = 0;
        public Queen(Worker[] workers, double weightMg) : base(weightMg)
        {
            _myWorkers = workers;
        }
        #endregion

        public bool AssignWork(string job, int shifts) //Просматриваем рабочих, при наличии свободных пчёл даем задание
        { 
            foreach(Worker worker in _myWorkers)
                if (worker.DoThisJob(job, shifts)) return true;
            return false;
        } 
        public string WorkTheNextShift() //Отработать одну смену
        {
            shiftNumber++;
            double honeyConsumedForTheShift = HoneyConsumptionRate();
            string report = "Report for shift # " + shiftNumber + "\r\n";
            for(int i = 0; i < _myWorkers.Length; i++)
            {
                honeyConsumedForTheShift += _myWorkers[i].HoneyConsumptionRate();
                if (_myWorkers[i].DidYouFinish())
                    report += $"Worker #{i + 1} " + "finished the job\r\n";
                if (String.IsNullOrEmpty(_myWorkers[i].CurrectJob))
                    report += $"Worker #{i + 1} " + "is not working\r\n";
                else
                    if (_myWorkers[i].ShiftsLeft > 0)
                    report += $"Worker #{i + 1} " + "is doing `" + _myWorkers[i].CurrectJob + "` for more " + _myWorkers[i].ShiftsLeft + " shifts\r\n";
                else
                    report += $"Worker #{i + 1} " + "is finishing " + _myWorkers[i].CurrectJob + " after this shift\r\n";
            }
            report += "Total honey consumed for the shift " + honeyConsumedForTheShift + " units\r\n";
            return report;
        }
    }
}
