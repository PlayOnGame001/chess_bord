using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chess_bord
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Piant(object sender, EventArgs e)
        {
            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
                  bool Black_pool = false;
            Pen pen = new Pen(Color.Black);
            Brush brush = new SolidBrush(Color.Black);
            Rectangle rect = new Rectangle();
            Graphics g = e.Graphics;
            for (int i = 1; i <= 8; i++)
            {
                for (int j = 1; j <= 8; j++)
                {
                    if (Black_pool)
                    {
                        rect = new Rectangle(i * 40, j * 40, 40, 40);
                        g.DrawRectangle(pen, rect);
                        g.FillRectangle(brush, rect);
                        Black_pool = false;
                    }
                    else
                        Black_pool = true;
                }
                Black_pool = !Black_pool;
            }
        }
    }
}
