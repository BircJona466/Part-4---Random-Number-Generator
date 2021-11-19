using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part_4___Random_Number_Generator
{
    public partial class RandomNumberGenerator : Form
    {
        Random generator = new Random();
        

        public RandomNumberGenerator()
        {
            InitializeComponent();
        }

        private void lblMaximum_Click(object sender, EventArgs e)
        {

        }

        private void btnInteger_Click(object sender, EventArgs e)
        {
            if (numMinimum.Value >= numMaximum.Value)
            {

            }
            else
            {
                lblResult.Text = Convert.ToString(generator.Next((int)numMinimum.Value, (int)numMaximum.Value));
            }     
            
            
            
           
        }

        private void btnDouble_Click(object sender, EventArgs e)
        {
            if (numMinimum.Value >= numMaximum.Value)
            {

            }
            else
            {
                lblResult.Text = Convert.ToString(GetRandomNumber());
            }

        }

        

        public double GetRandomNumber()
        {
            Random random = new Random();
            return random.NextDouble() * ((double)numMaximum.Value - (double)numMinimum.Value) + (double)numMinimum.Value;
        }
    }
}
