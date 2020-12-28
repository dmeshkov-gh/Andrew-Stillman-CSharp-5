using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeehiveManagementWF_p._301
{
    public partial class Form1 : Form
    {
        Queen queen;
        public Form1()
        {
            InitializeComponent();
            workerBeeJob.SelectedIndex = 0;
            Worker[] workers = new Worker[4];
            workers[0] = new Worker(new string[] { "Nectar collector", "Honey manufacturing" });
            workers[1] = new Worker(new string[] { "Egg care", "Baby bee tutoring" });
            workers[2] = new Worker(new string[] { "Hive maintenance", "Sting patrol" });
            workers[3] = new Worker(new string[] { "Nectar collector", "Honey manufacturing", 
                "Egg care", "Baby bee tutoring", "Hive maintenance", "Sting patrol" });
            queen = new Queen(workers);
        }

        private void btnNextShift_Click(object sender, EventArgs e)
        {
            tBoxReport.Text = queen.WorkTheNextShift();
        }

        private void btnAssignJob_Click(object sender, EventArgs e)
        {
            if (queen.AssignWork(workerBeeJob.Text, (int)shifts.Value) == false)
                MessageBox.Show("There is no workers for this job " + workerBeeJob.Text + " - Queen said");
            else
                MessageBox.Show("Job " + workerBeeJob.Text + " will be done within " + shifts.Value + " shifts " +  "- Queen said");
        }
    }
}
