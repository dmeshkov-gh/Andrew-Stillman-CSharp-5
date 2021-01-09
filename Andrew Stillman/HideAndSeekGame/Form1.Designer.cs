namespace HideAndSeekGame
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
            this.goThroughTheDoor_btn = new System.Windows.Forms.Button();
            this.goHere_btn = new System.Windows.Forms.Button();
            this.exits_cb = new System.Windows.Forms.ComboBox();
            this.description_tb = new System.Windows.Forms.TextBox();
            this.check_btn = new System.Windows.Forms.Button();
            this.hide_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // goThroughTheDoor_btn
            // 
            this.goThroughTheDoor_btn.Location = new System.Drawing.Point(0, 205);
            this.goThroughTheDoor_btn.Name = "goThroughTheDoor_btn";
            this.goThroughTheDoor_btn.Size = new System.Drawing.Size(307, 23);
            this.goThroughTheDoor_btn.TabIndex = 0;
            this.goThroughTheDoor_btn.Text = "Go through the exterior door";
            this.goThroughTheDoor_btn.UseVisualStyleBackColor = true;
            this.goThroughTheDoor_btn.Visible = false;
            this.goThroughTheDoor_btn.Click += new System.EventHandler(this.goThroughTheDoor_btn_Click);
            // 
            // goHere_btn
            // 
            this.goHere_btn.Location = new System.Drawing.Point(0, 176);
            this.goHere_btn.Name = "goHere_btn";
            this.goHere_btn.Size = new System.Drawing.Size(111, 21);
            this.goHere_btn.TabIndex = 1;
            this.goHere_btn.Text = "Go here:";
            this.goHere_btn.UseVisualStyleBackColor = true;
            this.goHere_btn.Visible = false;
            this.goHere_btn.Click += new System.EventHandler(this.btn_GoHere_Click);
            // 
            // exits_cb
            // 
            this.exits_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.exits_cb.FormattingEnabled = true;
            this.exits_cb.Location = new System.Drawing.Point(117, 176);
            this.exits_cb.Name = "exits_cb";
            this.exits_cb.Size = new System.Drawing.Size(190, 21);
            this.exits_cb.TabIndex = 2;
            this.exits_cb.Visible = false;
            // 
            // description_tb
            // 
            this.description_tb.Dock = System.Windows.Forms.DockStyle.Top;
            this.description_tb.Location = new System.Drawing.Point(0, 0);
            this.description_tb.Multiline = true;
            this.description_tb.Name = "description_tb";
            this.description_tb.Size = new System.Drawing.Size(302, 170);
            this.description_tb.TabIndex = 3;
            // 
            // check_btn
            // 
            this.check_btn.Location = new System.Drawing.Point(0, 234);
            this.check_btn.Name = "check_btn";
            this.check_btn.Size = new System.Drawing.Size(302, 23);
            this.check_btn.TabIndex = 4;
            this.check_btn.Text = "Check";
            this.check_btn.UseVisualStyleBackColor = true;
            this.check_btn.Visible = false;
            this.check_btn.Click += new System.EventHandler(this.check_btn_Click);
            // 
            // hide_btn
            // 
            this.hide_btn.Location = new System.Drawing.Point(0, 264);
            this.hide_btn.Name = "hide_btn";
            this.hide_btn.Size = new System.Drawing.Size(302, 23);
            this.hide_btn.TabIndex = 5;
            this.hide_btn.Text = "Hide!";
            this.hide_btn.UseVisualStyleBackColor = true;
            this.hide_btn.Click += new System.EventHandler(this.hide_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 294);
            this.Controls.Add(this.hide_btn);
            this.Controls.Add(this.check_btn);
            this.Controls.Add(this.description_tb);
            this.Controls.Add(this.exits_cb);
            this.Controls.Add(this.goHere_btn);
            this.Controls.Add(this.goThroughTheDoor_btn);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Explore the House";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button goThroughTheDoor_btn;
        private System.Windows.Forms.Button goHere_btn;
        private System.Windows.Forms.ComboBox exits_cb;
        private System.Windows.Forms.TextBox description_tb;
        private System.Windows.Forms.Button check_btn;
        private System.Windows.Forms.Button hide_btn;
    }
}