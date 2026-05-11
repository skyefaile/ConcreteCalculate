// Skye Faile

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConcreteCalculate
{
    public partial class Form1 : Form
    {
        //The depth of every driveway.
        const double DRIVEWAY_DEPTH = 0.5;
        //Amount of concrete created from 1 kg of cement
        const double CONCRETE_PER_KG = 1.5;
        //Weight of a bag of cement
        const double BAG_WEIGHT = 2.0;
        //Cost of a bag of cement
        const decimal BAG_COST = 15.5m;


        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// The method will check that the user enters a valid value, if the value
        /// isn't valid, a error message will be displayed. It then takes the
        /// user's values and calculates the volume of concrete required, the amount
        /// of cement needed, the number of bags needed, and the total cost. It then displays
        /// these values. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            
                // Declare variables
                double volume = 0;
                double length = 0;
                double width = 0;

                bool lengthValid = double.TryParse(textBoxLength.Text, out length) && length >= 1 && length <= 100;
                bool widthValid = double.TryParse(textBoxWidth.Text, out width) && width >= 1 && width <= 100;

                if (!lengthValid && !widthValid)
                {
                    MessageBox.Show("Width and Length must be numbers between 1 and 100.");
                    textBoxLength.Focus();
                    return;
                }
                else if (!lengthValid)
                {
                    MessageBox.Show("Length must be a number between 1 and 100.");
                    textBoxLength.Focus();
                    return;
                }
                else if (!widthValid)
                {
                    MessageBox.Show("Width must be a number between 1 and 100.");
                    textBoxWidth.Focus();
                    return;
                }

                // Calculates the volume of concrete required
                volume = length * width * DRIVEWAY_DEPTH;

                // Display volume
                textBox1.Text = volume.ToString();

            }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// The method clears all the text boxes and sets the focus to the first textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
     
   

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBoxWeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxLength_TextChanged(object sender, EventArgs e)
        {

        }
   
 
    }
}
