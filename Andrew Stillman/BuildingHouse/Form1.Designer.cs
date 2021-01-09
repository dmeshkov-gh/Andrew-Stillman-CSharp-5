namespace BuildingHouse
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
            this.btn_GoHere = new System.Windows.Forms.Button();
            this.exits_cb = new System.Windows.Forms.ComboBox();
            this.description_tb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // goThroughTheDoor_btn
            // 
            this.goThroughTheDoor_btn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.goThroughTheDoor_btn.Location = new System.Drawing.Point(0, 205);
            this.goThroughTheDoor_btn.Name = "goThroughTheDoor_btn";
            this.goThroughTheDoor_btn.Size = new System.Drawing.Size(307, 23);
            this.goThroughTheDoor_btn.TabIndex = 0;
            this.goThroughTheDoor_btn.Text = "Go through the door";
            this.goThroughTheDoor_btn.UseVisualStyleBackColor = true;
            this.goThroughTheDoor_btn.Click += new System.EventHandler(this.goThroughTheDoor_btn_Click);
            // 
            // btn_GoHere
            // 
            this.btn_GoHere.Location = new System.Drawing.Point(0, 176);
            this.btn_GoHere.Name = "btn_GoHere";
            this.btn_GoHere.Size = new System.Drawing.Size(111, 21);
            this.btn_GoHere.TabIndex = 1;
            this.btn_GoHere.Text = "Go here:";
            this.btn_GoHere.UseVisualStyleBackColor = true;
            this.btn_GoHere.Click += new System.EventHandler(this.btn_GoHere_Click);
            // 
            // exits_cb
            // 
            this.exits_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.exits_cb.FormattingEnabled = true;
            this.exits_cb.Location = new System.Drawing.Point(117, 176);
            this.exits_cb.Name = "exits_cb";
            this.exits_cb.Size = new System.Drawing.Size(190, 21);
            this.exits_cb.TabIndex = 2;
            // 
            // description_tb
            // 
            this.description_tb.Dock = System.Windows.Forms.DockStyle.Top;
            this.description_tb.Location = new System.Drawing.Point(0, 0);
            this.description_tb.Multiline = true;
            this.description_tb.Name = "description_tb";
            this.description_tb.Size = new System.Drawing.Size(307, 170);
            this.description_tb.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 228);
            this.Controls.Add(this.description_tb);
            this.Controls.Add(this.exits_cb);
            this.Controls.Add(this.btn_GoHere);
            this.Controls.Add(this.goThroughTheDoor_btn);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Explore the House";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button goThroughTheDoor_btn;
        private System.Windows.Forms.Button btn_GoHere;
        private System.Windows.Forms.ComboBox exits_cb;
        private System.Windows.Forms.TextBox description_tb;
    }
}

