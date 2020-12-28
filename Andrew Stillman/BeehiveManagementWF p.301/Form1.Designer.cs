namespace BeehiveManagementWF_p._301
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gBoxBeeAssignments = new System.Windows.Forms.GroupBox();
            this.gBoxJob = new System.Windows.Forms.GroupBox();
            this.workerBeeJob = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.shifts = new System.Windows.Forms.NumericUpDown();
            this.btnAssignJob = new System.Windows.Forms.Button();
            this.btnNextShift = new System.Windows.Forms.Button();
            this.tBoxReport = new System.Windows.Forms.TextBox();
            this.gBoxBeeAssignments.SuspendLayout();
            this.gBoxJob.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shifts)).BeginInit();
            this.SuspendLayout();
            // 
            // gBoxBeeAssignments
            // 
            this.gBoxBeeAssignments.Controls.Add(this.btnAssignJob);
            this.gBoxBeeAssignments.Controls.Add(this.groupBox1);
            this.gBoxBeeAssignments.Controls.Add(this.gBoxJob);
            this.gBoxBeeAssignments.Location = new System.Drawing.Point(13, 13);
            this.gBoxBeeAssignments.Name = "gBoxBeeAssignments";
            this.gBoxBeeAssignments.Size = new System.Drawing.Size(340, 121);
            this.gBoxBeeAssignments.TabIndex = 0;
            this.gBoxBeeAssignments.TabStop = false;
            this.gBoxBeeAssignments.Text = "Worker Bee Assigments";
            // 
            // gBoxJob
            // 
            this.gBoxJob.Controls.Add(this.workerBeeJob);
            this.gBoxJob.Location = new System.Drawing.Point(7, 20);
            this.gBoxJob.Name = "gBoxJob";
            this.gBoxJob.Size = new System.Drawing.Size(198, 56);
            this.gBoxJob.TabIndex = 0;
            this.gBoxJob.TabStop = false;
            this.gBoxJob.Text = "Job";
            // 
            // workerBeeJob
            // 
            this.workerBeeJob.FormattingEnabled = true;
            this.workerBeeJob.Items.AddRange(new object[] {
            "Nectar collector",
            "Honey manufacturing",
            "Egg care",
            "Baby bee tutoring",
            "Hive maintenance",
            "Sting patrol"});
            this.workerBeeJob.Location = new System.Drawing.Point(7, 20);
            this.workerBeeJob.Name = "workerBeeJob";
            this.workerBeeJob.Size = new System.Drawing.Size(169, 21);
            this.workerBeeJob.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.shifts);
            this.groupBox1.Location = new System.Drawing.Point(206, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(126, 56);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shifts";
            // 
            // shifts
            // 
            this.shifts.Location = new System.Drawing.Point(7, 20);
            this.shifts.Name = "shifts";
            this.shifts.Size = new System.Drawing.Size(113, 20);
            this.shifts.TabIndex = 0;
            // 
            // btnAssignJob
            // 
            this.btnAssignJob.Location = new System.Drawing.Point(7, 83);
            this.btnAssignJob.Name = "btnAssignJob";
            this.btnAssignJob.Size = new System.Drawing.Size(325, 23);
            this.btnAssignJob.TabIndex = 2;
            this.btnAssignJob.Text = "Assign this job to a bee";
            this.btnAssignJob.UseVisualStyleBackColor = true;
            this.btnAssignJob.Click += new System.EventHandler(this.btnAssignJob_Click);
            // 
            // btnNextShift
            // 
            this.btnNextShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNextShift.Location = new System.Drawing.Point(360, 13);
            this.btnNextShift.Name = "btnNextShift";
            this.btnNextShift.Size = new System.Drawing.Size(156, 121);
            this.btnNextShift.TabIndex = 1;
            this.btnNextShift.Text = "Work the next shift";
            this.btnNextShift.UseVisualStyleBackColor = true;
            this.btnNextShift.Click += new System.EventHandler(this.btnNextShift_Click);
            // 
            // tBoxReport
            // 
            this.tBoxReport.Location = new System.Drawing.Point(13, 141);
            this.tBoxReport.Multiline = true;
            this.tBoxReport.Name = "tBoxReport";
            this.tBoxReport.Size = new System.Drawing.Size(503, 169);
            this.tBoxReport.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 322);
            this.Controls.Add(this.tBoxReport);
            this.Controls.Add(this.btnNextShift);
            this.Controls.Add(this.gBoxBeeAssignments);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Beehive Management System";
            this.gBoxBeeAssignments.ResumeLayout(false);
            this.gBoxJob.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.shifts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxBeeAssignments;
        private System.Windows.Forms.Button btnAssignJob;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown shifts;
        private System.Windows.Forms.GroupBox gBoxJob;
        private System.Windows.Forms.ComboBox workerBeeJob;
        private System.Windows.Forms.Button btnNextShift;
        private System.Windows.Forms.TextBox tBoxReport;
    }
}

