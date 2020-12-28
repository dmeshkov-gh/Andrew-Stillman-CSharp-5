using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagementWF_p._301
{
    class NectarCollector : Worker
    {
        public int Nectar { get; set; }
        public NectarCollector(string[] jobsICanDo, double weightMg) :base(jobsICanDo, weightMg)
        {
        }
        public void FindFlowers()
        {

        }
        public void GatherNectar()
        {

        }
        public void ReturnToHive()
        {

        }
    }
}
