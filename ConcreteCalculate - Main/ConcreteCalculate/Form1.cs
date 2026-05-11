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
            try
            {
                // Declare variables
                double volume = 0;
                double weight = 0;
                decimal cost = 0;
                int bags = 0;
                double length = 0;
                double width = 0;

                // Validate the user's input
                bool lengthValid = double.TryParse(textBoxLength.Text, out length) && length >= 1 && length <= 100;
                bool widthValid = double.TryParse(textBoxWidth.Text, out width) && width >= 1 && width <= 100;

                // If length and width are valid
                if (!lengthValid && !widthValid)
                {
                    // Display error message
                    MessageBox.Show("Width and Length must be numbers between 1 and 100.");
                    // Clear all the textboxes
                    textBoxWidth.Clear();
                    textBoxLength.Clear();
                    textBoxCost.Clear();
                    textBoxVolume.Clear();
                    textBoxWeight.Clear();
                    textBoxBags.Clear();
                    // Set focus to the first textbox
                    textBoxWidth.Focus();
                    // Stop the program from continuing
                    return;
                }
                // If just length is valid
                else if (!lengthValid)
                {
                    // Display error message
                    MessageBox.Show("Length must be a number between 1 and 100.");
                    // Clear all the textboxes
                    textBoxWidth.Clear();
                    textBoxLength.Clear();
                    textBoxCost.Clear();
                    textBoxVolume.Clear();
                    textBoxWeight.Clear();
                    textBoxBags.Clear();
                    // Set focus to the first textbox
                    textBoxWidth.Focus();
                    // Stop the program from continuing
                    return;
                }
                // If just width is valid
                else if (!widthValid)
                {
                    // Display error message
                    MessageBox.Show("Width must be a number between 1 and 100.");
                    // Clear all the textboxes
                    textBoxWidth.Clear();
                    textBoxLength.Clear();
                    textBoxCost.Clear();
                    textBoxVolume.Clear();
                    textBoxWeight.Clear();
                    textBoxBags.Clear();
                    // Set focus to the first textbox
                    textBoxWidth.Focus();
                    // Stop the program from continuing
                    return;
                }

                // Calculates the volume of concrete required
                volume = length * width * DRIVEWAY_DEPTH;

                // Calculates the amount of cement needed (kg)
                weight = volume / CONCRETE_PER_KG;

                // Calculates the number of bags required
                bags = (int)Math.Ceiling(weight / BAG_WEIGHT);

                // Calculates the total cost of the cement
                cost = bags * BAG_COST;

                // Displays the results
                textBoxVolume.Text = volume.ToString("n3");
                textBoxWeight.Text = weight.ToString("n3");
                textBoxBags.Text = bags.ToString();
                textBoxCost.Text = cost.ToString("c");

            }
            catch
            {
                // Displays error message if the values are not valid
                MessageBox.Show("Please enter valid values");

                // Clears all the text boxes
                textBoxWidth.Clear();
                textBoxLength.Clear();
                textBoxCost.Clear();
                textBoxVolume.Clear();
                textBoxWeight.Clear();
                textBoxBags.Clear();

                // Sets focus to first text box
                textBoxWidth.Focus();
            }

        }

        /// <summary>
        /// The method clears all the text boxes and sets the focus to the first textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClear_Click(object sender, EventArgs e)
        {
            // Clears the text boxes
            textBoxWidth.Clear();
            textBoxLength.Clear();
            textBoxCost.Clear();
            textBoxVolume.Clear();
            textBoxWeight.Clear();
            textBoxBags.Clear();

            // Sets focus to first text box
            textBoxWidth.Focus();

        }

        /// <summary>
        /// This method displays information on how to use the
        /// concrete caclulator
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            // Displays help information
            MessageBox.Show(
                "Concrete Calculator Help\n\n" +
                "1. Enter the length (0–100 meters).\n" +
                "2. Enter the width (0–100 meters).\n" +
                "3. Click 'Calculate'.\n\n" +
                "Use 'Clear' to reset.\n" +
                "Click 'Exit' to close the program.",
                "Help",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        /// <summary>
        /// The method exits the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExit_Click(object sender, EventArgs e)
        {
            // Exits the application
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

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
