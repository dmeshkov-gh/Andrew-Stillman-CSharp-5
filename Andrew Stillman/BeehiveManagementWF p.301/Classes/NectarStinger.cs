using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagementWF_p._301.Classes
{
    class NectarStinger : Worker, INectarCollector, IStingPatrol
    {
        public NectarStinger(string[] jobsICanDo, double weightMg) : base(jobsICanDo, weightMg)
        {
        }

        public int AlertLevel => throw new NotImplementedException();

        public int StingerLenght { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void FindFlowers()
        {
            throw new NotImplementedException();
        }

        public void GatherNectar()
        {
            throw new NotImplementedException();
        }

        public bool LookForEnemies()
        {
            throw new NotImplementedException();
        }

        public void ReturnToHive()
        {
            throw new NotImplementedException();
        }

        public int SharpenStinger(int lenght)
        {
            throw new NotImplementedException();
        }
    }
}
