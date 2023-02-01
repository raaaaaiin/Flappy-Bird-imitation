using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Boolean once = false;
        public Rectangle floor;
        public Rectangle pipelow;
        public Rectangle pipehigh;
        public Rectangle scoringe;
        public Boolean isScore;
        public Boolean iscollidefloor;
        public Boolean iscollidehigh;
        public Boolean iscollidelow;
        Thread jump;
        public Boolean gameover;
        Random rnd = new Random();
        int rndomNumber;
        Form2[] pipe = new Form2[10000];
        public int score;
        public int next_pipe;
        Graphics e;
        public Form1()
        {

            InitializeComponent();
            gameover = false;
            score = 0;
            next_pipe = 0;
            Panel.CheckForIllegalCrossThreadCalls = false;
            timer1.Start();
            pipecreation();
            pipee.Start();

            floor = new Rectangle(Ground.Location.X, Ground.Location.Y, Ground.Width, Ground.Height);
        }
        public void Timer()
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void pipecreation()
        {
            next_pipe += 1;
            rndomNumber = rnd.Next(-120, -35);
            pipe[next_pipe] = new Form2(this) { TopLevel = false };

            //pipelow = new Rectangle(pipe[next_pipe].Location.X, pipe[next_pipe].Location.Y, pipe[next_pipe].Width, pipe[next_pipe].Height);
            //pipehigh = new Rectangle(pipe[next_pipe].panel3.Location.X, pipe[next_pipe].panel3.Location.Y, pipe[next_pipe].panel3.Width, pipe[next_pipe].panel3.Height);
            //scoringe = new Rectangle(pipe[next_pipe].score.Location.X, pipe[next_pipe].score.Location.Y, pipe[next_pipe].score.Width, pipe[next_pipe].score.Height);
            panel4.Controls.AddRange(pipe);
            pipe[next_pipe].BringToFront();
            pipe[next_pipe].Location = new Point(300, rndomNumber);
            pipe[next_pipe].Visible = true;
        }




        private void timer1_Tick_1(object sender, EventArgs e)
        {

            collision();
            //panel1.Top += 2;

        }
        public void collision()
        {

            //iscollidehigh = pipehigh.Contains(panel1.Location.X, panel1.Location.Y);

            iscollidehigh = pipehigh.Contains(panel1.Location.X, panel1.Location.Y);
            iscollidelow = pipelow.Contains(panel1.Location.X, panel1.Location.Y);
            iscollidefloor = pipehigh.Contains(panel1.Location.X + 28, panel1.Location.Y);
            isScore = scoringe.Contains(panel1.Location.X + 28, panel1.Location.Y);
            iscollidefloor = floor.Contains(panel1.Location.X + 40, panel1.Location.Y + 29);
            if (iscollidelow == true )
            {
                gameover = true;
                pipee.Stop();
                label1.Text = "low";

            }
            else if (iscollidehigh == true)
            {
                gameover = true;
                pipee.Stop();
                label1.Text = "high";
            }
            else if (iscollidefloor == true)
            {
                gameover = true;
                pipee.Stop();
                timer1.Stop();
                label1.Text = "GG";
            }
            else if (isScore == true)
            {
                if (once == false)
                {

                    score++;
                    once = true;
                }
                label1.Text = score.ToString();
            }
        }

        public void Global_click(object sender, EventArgs e)
        {
            juump();
        }
        public void scoring()
        {
            //iscollide = floor.Contains(panel1.Location.X + 40, panel1.Location.Y + 35);
        }
        public void juump()
        {
            if(gameover == false)
            {

                panel1.Top -= 120;
            }
        }

        private void pipee_Tick(object sender, EventArgs e)
        {
           
            try
            {
                pipehigh = new Rectangle(pipe[score].Location.X, pipe[score].Location.Y, pipe[score].Width, pipe[score].Height - 423);
                pipelow = new Rectangle(pipe[score].Location.X, pipe[score].Location.Y + 346, pipe[score].Width, pipe[score].Height);
                scoringe = new Rectangle(pipe[score].Location.X, pipe[score].Location.Y + 173, pipe[score].Width, pipe[score].Height - 423);
                panel2.Height = pipelow.Height;
                panel2.Width = pipelow.Width + 20;
                panel2.Location = pipelow.Location;
            }
            catch
            {
                pipehigh = new Rectangle(pipe[score + 1].Location.X, pipe[score+1].Location.Y, pipe[score + 1].Width, pipe[score + 1].Height - 423);
                pipelow = new Rectangle(pipe[score + 1].Location.X, pipe[score + 1].Location.Y + 346, pipe[score + 1].Width, pipe[score + 1].Height);
                scoringe = new Rectangle(pipe[score + 1].Location.X, pipe[score + 1].Location.Y + 173, pipe[score + 1].Width, pipe[score + 1].Height - 423);
                panel2.Height = pipelow.Height;
                panel2.Width = pipelow.Width+20;
                panel2.Location = pipelow.Location;

            }
           
            label2.Text = pipe[next_pipe].panel1.Location.X.ToString();
            pipe[next_pipe].Left--;
            if (pipe[next_pipe].Location.X == 25)
            {
                pipecreation();

            }
            try
            {
                pipe[next_pipe - 1].Left--;
                if (pipe[next_pipe - 1].Location.X == -73)
                {
                    pipe[next_pipe - 1].Dispose();

                }
                else
                {

                }
            }
            catch
            {

            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

