// todo:
// fix ui
// double test everything
// go over all code again and make sure comments exist
// fix help button to not be rude
// fix numbers going off screen

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        double firstNumber; // stores the first number when MathOperationHandler runs
        string operation = ""; // stores the math type thingy when MathOperationHandler runs
        bool isOperationClicked = false; // when math type is clicked this is set to true and clears MathResult
        public Form1() // this is here by defauly
        {
            InitializeComponent();
        }

        //
        // Form Load
        //
        private void Form1_Load(object sender, EventArgs e)
        {
            //this is also here by defauly but i know if i put something in here like a messagebox then it will pop up the second the program is opened
        }

        //
        // Help Button
        //

        private void HelpButton_Click(object sender, EventArgs e) // a useless help button
        {
            MessageBox.Show("If you need help using a calculator then you shouldnt be using one...");
        }

        //
        // Backspace Button
        //

        private void MathBackspace_Click(object sender, EventArgs e) // removes 1 number
        {
            if (MathResult.Text.Length > 0)  // if there is more than 0 numbers in MathResult then:
            {
                MathResult.Text = MathResult.Text.Substring(0, MathResult.Text.Length - 1); // this is confusing and idk how it works but it removes the last/newest number. i think it works by getting total amount of numbers and then removing 1 from that total amount or something. darn you ai for sucking at explaining
            }
            else // if there isnt more than 0 numbers then:
            {
                MessageBox.Show("hey dumbass there are no numbers to remove"); // hehe
            }
        }

        //
        // Clear Button
        //

        private void MathClear_Click(object sender, EventArgs e) // clear MathResult button
        {
            if (MathResult.Text.Length > 0)  // sjekker om at boksen er tom og vis den ikke er tom så kjører den koden nedenfor
            {
                MathResult.Text = (""); // clears MathResult
                operation = ""; // sets operaion to nothing aka the thing that remembers what was clicked like +, -, * or /
                isOperationClicked = false; // sets isOperationClicked to false
                MathTypeLabel.Text = ""; // clears the mathtypelabel
            }
            else
            {
                MessageBox.Show("hey dumbass there are no numbers to remove"); // tihi
            }
        }

        //
        // Dot Button
        //

        private void MathDot_Click(object sender, EventArgs e) // adds a dot
        {
            MathResult.Text += "."; // idk if this works but we ball. spoilers: it did work
        }

        //
        // Number Buttons
        //

        private void NumberButtonClick(object sender, EventArgs e)
        {
            string NumberInButton = ((Button)sender).Text; // this gets what number was clicked

            if (isOperationClicked)
            {
                isOperationClicked = false; // if isOperationClicked = true then make it false
                MathResult.Text += NumberInButton; // add the number that was clicked from string NumberInButton
            }
            else
            {
                MathResult.Text += NumberInButton; // add the number that was clicked from string NumberInButton
            }
        }
        // dude help this is complicated my brain hurts aaaaa

        //
        // Percentage Button
        //

        private void MathPercent_Click(object sender, EventArgs e) // percentage button thingy
        {
            if (string.IsNullOrEmpty(MathResult.Text))
            {
                MessageBox.Show("Please enter a number first.");
                return;
            }
            double currentValue = double.Parse(MathResult.Text); // sets currentValue to whatever MathResult is but also "parses" it into a integer
            double result = currentValue / 100; // grabs result and divides it by 100
            MathResult.Text = result.ToString(); // gets result, translates it into string and slaps it in the result box
        }

        //
        // Math Type Button
        //

        private void MathOperatorHandler(object sender, EventArgs e) // when thing is clicked, check if old thing is setup, if yes then do old calculation and then set the new thingy as active operation, if no set the thingy as the new active
        {
            if (string.IsNullOrEmpty(MathResult.Text))
            {
                MessageBox.Show("Please enter a number first.");
                return;
            }
            if (!string.IsNullOrEmpty(operation)) // checks if there isnt a active operation
            {
                MathEquals_Click(sender, e); // if there is a operation waiting then do the calculation now
                // when the calculation has been completed store the new numbers
                firstNumber = double.Parse(MathResult.Text); // make firstnumber into double data and stores the current result
                operation = ((Button)sender).Text; // set the new operation
                isOperationClicked = true; // set isoperationclicked to true
                MathTypeLabel.Text = operation; // put the new selected operation in the mathlabeltype
                MathResult.Text = ""; // sets the result to nothing
            }
            else
            {
                firstNumber = double.Parse(MathResult.Text); // remembers what the first number was
                operation = ((Button)sender).Text; // remembers what math type the user selected
                MathResult.Text = (""); // clears the mathresult label
                isOperationClicked = true; // sets isoperationclicked to true
                MathTypeLabel.Text = operation; // sets the mathtypelabel as the math type that the user selected by checking what the value of operation is
            }
        }

        //
        // Main Math Code (when equals gets clicked)
        //

        private void MathEquals_Click(object sender, EventArgs e) // on equals click:
        {
            if (string.IsNullOrEmpty(MathResult.Text)) // checks if mathresult is empty. if it is then show a error message. if not then continue
            {
                MessageBox.Show("Please enter a number to perform a calculation.");
                return; // exit the method to stop a crash from happening
            }

            double secondNumber = double.Parse(MathResult.Text); // sets the second number as what is in the mathresult box
            double result = 0; // sets result to 0 temporarily

            // im using a switch statement here as i feel like that makes it easier on both coding and just readability
            switch (operation)
            {
                case "+": // if + clicked then plusses both numbers. i aint gonna sit here and add comments to each and every one and you can guess what the others do anyway
                    result = firstNumber + secondNumber;
                    break; // break exits this switch and stops the other code like * or / from executing
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                case "X":
                    result = firstNumber * secondNumber;
                    break;
                case "/":
                    if (secondNumber != 0)
                    {
                        result = firstNumber / secondNumber;
                    }
                    else
                    {
                        MathResult.Text = "Error"; // u cannot divide something with 0 smartass
                        return;
                    }
                    break;
            }

            // displays the final result
            MathResult.Text = result.ToString();

            // now that equals is clicked it can clear all the old stuff
            operation = ""; // clear the operation
            isOperationClicked = false; // set isoperationclicked to false
            MathTypeLabel.Text = ""; // empties mathtypelabel
        }

        //
        // Other
        //

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            // paint? paint. PAINT! (idk why this is here or what its doing)
        }

        private void MathResult_Click(object sender, EventArgs e)
        {
            // how the hell did this get here
        }
    }
} // huh
