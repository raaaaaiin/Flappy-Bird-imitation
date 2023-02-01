namespace WindowsFormsApp4
{
    partial class Form2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.score = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Location = new System.Drawing.Point(9, 346);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(57, 317);
            this.panel1.TabIndex = 0;
            this.panel1.Click += new System.EventHandler(this.Do_amazing_things);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Green;
            this.panel3.Location = new System.Drawing.Point(9, -120);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(57, 292);
            this.panel3.TabIndex = 1;
            this.panel3.Click += new System.EventHandler(this.Do_amazing_things);
            // 
            // score
            // 
            this.score.Location = new System.Drawing.Point(3, 179);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(69, 161);
            this.score.TabIndex = 3;
            this.score.Click += new System.EventHandler(this.Do_amazing_things);
            this.score.Paint += new System.Windows.Forms.PaintEventHandler(this.score_Paint);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(74, 596);
            this.Controls.Add(this.score);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Click += new System.EventHandler(this.Do_amazing_things);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Panel score;
    }
}