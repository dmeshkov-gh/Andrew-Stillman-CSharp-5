using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagementWF_p._301
{
    interface IStingPatrol
    {
        int AlertLevel { get; }
        int StingerLenght { get; set; }
        bool LookForEnemies();
        int SharpenStinger(int lenght);
    }
}
