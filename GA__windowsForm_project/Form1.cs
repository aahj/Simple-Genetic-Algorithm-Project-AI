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

        //Runs the Microbial GA to solve the problem domain
        //Where the problem domain is specified as follows
        //
        //You have 10 cards numbered 1 to 10.
        //You have to divide them into 2 piles so that:
        //
        //The sum of the first pile is as close as possible to 36
        //And the product of all in second pile is as close as poss to 360
        public void run(int oop)
        {
            SUMTARG = double.Parse(sum_input.Text);
            PRODTARG = double.Parse(product_input.Text);
            END = double.Parse(tour_input.Text);

            //declare pop member a,b, winner and loser
            int a, b, Winner, Loser;
            //initialise the population (randomly)
            init_pop();
            //start a tournament
            for (int tournamentNo = 0; tournamentNo < END; tournamentNo++)
            {
                //pull 2 population members at random
                a = (int)(POP * rnd.NextDouble());
                b = (int)(POP * rnd.NextDouble());
                //have a fight, see who has best genes
                if (evaluate(a) < evaluate(b))
                {
                    Winner = a;
                    Loser = b;
                }
                else
                {
                    Winner = b;
                    Loser = a;
                }
                //Possibly do some gene jiggling, on all genes of loser
                //again depends on randomness (simulating the natural selection
                //process of evolutionary selection)
                for (int i = 0; i < LEN; i++)
                {
                    //maybe do some recombination
                    if (rnd.NextDouble() < REC)
                        gene[Loser, i] = gene[Winner, i];
                    //maybe do some muttion
                    if (rnd.NextDouble() < MUT)
                        gene[Loser, i] = 1 - gene[Loser, i];
                    //then test to see if the new population member is a winner
                    if (evaluate(Loser) == 0.0)
                        display(tournamentNo, Loser, oop);
                }
            }
        }

        //evaluate the the nth member of the population
        //@param n : the nth member of the population
        //@return : the score for this member of the population.
        //If score is 0.0, then we have a good GA which has solved
        //the problem domain
        private double evaluate(int n)
        {
            //initialise field values
            int sum = 0, prod = 1;
            double scaled_sum_error, scaled_prod_error, combined_error;
            //loop though all genes for this population member
            for (int i = 0; i < LEN; i++)
            {
                //if the gene value is 0, then put it in the sum (pile 0), and calculate sum
                if (gene[n, i] == 0)
                {
                    sum += (1 + i);
                }
                //if the gene value is 1, then put it in the product (pile 1), and calculate sum
                else
                {
                    prod *= (1 + i);
                }
            }
        }

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


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void next_Click(object sender, EventArgs e)
        {
            panel1.Invalidate();
        }

        private void color_Click(object sender, EventArgs e)
        {
            colordialogue.ShowDialog();
        }
    }
}
