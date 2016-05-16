using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//    Program:   Fat Percentage Calculator
//  Developer:   Mikael Taylor
//Description:   This program displays fat calories, fat caloric percentage, 
//               as well as informs the user if a food is low fat based on
//               total calorie and fat gram input.  
namespace FatPercentageCalculator
{
    public partial class fatPercentageForm : Form
    {
        //Initialize components. It's just the right thing to do. 
        public fatPercentageForm()
        {
            InitializeComponent();
        }
        //end initialize components
        //Load the form.
        private void fatPercentageForm_Load(object sender, EventArgs e)
        {
        }
        //end load form
        //When the submit button is clicked, analyze the data and perform the appropriate actions, listed below
        private void submitButton_Click(object sender, EventArgs e)
        {
            //Initialize the variables
            double fatGrams;
            double totalCalories;
            double fatCalories;
            double fatCaloriesPercentage;
            //variables initialized
            //Nifty try/catch method.
            try
            {
                //Gather user input for fat grams, and total calories to be put into variables to be used with calculations.
                fatGrams = Double.Parse(fatGramsInputText.Text);
                totalCalories = Double.Parse(totalCaloriesInputText.Text);
                //Fat calories cannot exceed total number of calories, so we'll validate it. Not specified in the book, but we'll validate anyway.
                if (fatGrams * 9 > totalCalories)
                {
                    MessageBox.Show("It seems you've incorrectly entered either the fat grams data, or the total calories data. Check your work, and try again");
                    totalCaloriesInputText.Text = "";
                    fatGramsInputText.Text = "";
                }//end caloric validation
                //Let's do some math.  Fat Grams * 9 should result in the fat calories.
                //Fat calorie percentage should be the fat calories divided by the total calories, according to the book.
                fatCalories = fatGrams * 9;
                fatCaloriesPercentage = fatCalories / totalCalories;
                //Let's display the results.
                fatPercentageOutputResults.Text = fatCaloriesPercentage.ToString("0%");
                fatGramsOutputResults.Text = Convert.ToString(fatGrams);
                totalCaloriesOutputResults.Text = Convert.ToString(totalCalories);
                fatCaloriesOutputResults.Text = Convert.ToString(fatCalories);
                //If the percentage of fat calories is within the 30% range, and the checkbox has been checked,
                //let the user know that the food is indeed, low fat.
                if (fatCaloriesPercentage < .3 && lowFatInputCheckbox.Checked == true)
                {
                    lowFatOutputLabel.Text = "This food is low fat.";
                }//end if checked and low fat
                //otherwise, if the percentage of fat calories is not within the 30% range, and the checkbox is checked,
                //tell the user the truth, that this food is not low fat.
                else if (fatCaloriesPercentage > .3 && lowFatInputCheckbox.Checked == true)
                {
                    lowFatOutputLabel.Text = "This food is not low fat.";
                }//end if checked and not low fat
                //If the user has not checked the box indicating they would like to know if the food is low fat,
                //clear the low fat label so that they don't have to know.
                if (lowFatInputCheckbox.Checked == false)
                {
                    lowFatOutputLabel.Text = " ";
                } //end if not checked
            }//end try
            //Shoot off an error message if something goes wrong. Denote which error is popping up.(catch)
            catch (Exception ex)
            {
                //Error message box.
                MessageBox.Show("An error occurred: " + ex, "Fat Percentage Calculator v1.0 ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //end catch
        }
        //If the user clicks the clear button, clear all of the INPUT, and RESULTS.  We're nice like that.
        private void clearButton_Click(object sender, EventArgs e)
        {
            //Clear the results.
            totalCaloriesOutputResults.Text = "0";
            fatPercentageOutputResults.Text = "0";
            lowFatOutputLabel.Text = " ";
            fatCaloriesOutputResults.Text = "0";
            fatGramsOutputResults.Text = "0";
            //Clear the user input.
            totalCaloriesInputText.Text = "";
            fatGramsInputText.Text = "";
            //Don't forget the checkbox!
            lowFatInputCheckbox.Checked = false;
        }// end clear button
        //We don't want the user entering negative numbers, or letters because it's nonsensical. Keypress validation seemed the easiest way to do this
        //without causing any headaches.
        private void totalCaloriesInputText_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Allow control characters, e.g. backspace
            if (Char.IsControl(e.KeyChar)) return;
            //Allow periods, when they make sense.
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.Contains('.') == false)) return;
            //Allow numbers, but not letters.
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                MessageBox.Show("Please enter a valid, non-negative number");
                e.KeyChar = (char)0;
            }//end allow numbers, not letters
        }//end totalcaloriesinputtext keypress validation
        //We don't want the user entering negative numbers, or letters because it's nonsensical. Keypress validation seemed the easiest way to do this
        //without causing any headaches.
        private void fatGramsInputText_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Allow control characters, e.g. backspace
            if (Char.IsControl(e.KeyChar)) return;
            //Allow periods, when they make sense.
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.Contains('.') == false)) return;
            //Allow numbers, but not letters.
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                MessageBox.Show("Please enter a valid, non-negative number");
                e.KeyChar = (char)0;
            }//end allow numbers, not letters
        }

        private void totalCaloriesInputText_TextChanged(object sender, EventArgs e)
        {

        }//end fatgramsinputtext keypress validation.
    }//end fatpercentageform class
}//end fatpercentagecalculator program

