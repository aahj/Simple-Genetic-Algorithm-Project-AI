using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GA__windowsForm_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ColorDialog colordialogue = new ColorDialog();

        public void design_the_interface()
        {
            Color mycolor = colordialogue.Color;
            Graphics gr = panel1.CreateGraphics();
            Pen mypen = new Pen(mycolor, 1);
            int lines = int.Parse(textBox1.Text);
            float x = 0f, y = 0f;
            float xSpace = panel1.Width / lines;
            float ySpace = panel1.Height / lines;
            Font myfont = new Font("Arial", (panel1.Width < panel1.Height ? xSpace / 3 : ySpace / 3));

            //Vertical lines
            for (int i = 0; i < lines + 1; i++)
            {
                gr.DrawLine(mypen, x, y, x, ySpace * lines);
                x += xSpace;
            }

            x = 0f;
            //horizontal lines
            for (int i = 0; i < lines + 1; i++)
            {
                gr.DrawLine(mypen, x, y, xSpace * lines, y);
                y += ySpace;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
