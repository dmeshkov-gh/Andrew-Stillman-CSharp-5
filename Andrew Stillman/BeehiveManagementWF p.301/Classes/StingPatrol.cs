using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagementWF_p._301
{
    class StingPatrol : Worker
    {
        public int StingerLenght { get; set; }
        public int EnemyAlert { get; set; }
        public StingPatrol(string[] jobsICanDo, double weightMg, int stinglerLenght, int enemyAlert) 
            : base(jobsICanDo, weightMg)
        {
            StingerLenght = stinglerLenght;
            EnemyAlert = enemyAlert;
        }
        public bool SharpenStinger(int Lenght)
        {

        }
        public bool LookingForEnemies()
        {

        }
        public void Sting(string Enemy)
        {

        }
    }
}
