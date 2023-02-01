namespace WindowsFormsApp4
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Ground = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pipee = new System.Windows.Forms.Timer(this.components);
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Location = new System.Drawing.Point(25, 205);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(37, 30);
            this.panel1.TabIndex = 0;
            this.panel1.Click += new System.EventHandler(this.Global_click);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Ground
            // 
            this.Ground.BackColor = System.Drawing.SystemColors.Desktop;
            this.Ground.Location = new System.Drawing.Point(1, 364);
            this.Ground.Name = "Ground";
            this.Ground.Size = new System.Drawing.Size(301, 42);
            this.Ground.TabIndex = 3;
            this.Ground.Click += new System.EventHandler(this.Global_click);
            // 
            // timer1
            // 
            this.timer1.Interval = 3;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(1, -3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(301, 395);
            this.panel4.TabIndex = 4;
            this.panel4.Click += new System.EventHandler(this.Global_click);
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Location = new System.Drawing.Point(25, 106);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(93, 77);
            this.panel2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(114, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 73);
            this.label1.TabIndex = 2;
            this.label1.Text = "0";
            // 
            // pipee
            // 
            this.pipee.Interval = 15;
            this.pipee.Tick += new System.EventHandler(this.pipee_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 391);
            this.Controls.Add(this.Ground);
            this.Controls.Add(this.panel4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Click += new System.EventHandler(this.Global_click);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel Ground;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Timer pipee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
    }
}

