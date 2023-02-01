using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form2 : Form
    {
        Form1 ths;
        public Form2(Form1 main)
        {
            InitializeComponent();
            ths = main;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Do_amazing_things(object sender, EventArgs e)
        {
            ths.juump();
        }

        private void score_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
