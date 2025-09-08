// todo:
// fix ui
// double test everything
// go over all code again and make sure comments exist
// make the calculator support 3 or more different numbers?? (thinking of rewriting all the code so it can make new variables as the user uses and then clears all the variables when the user clicks clear)
// fix calc crashing after clicking plus or something and then equals
// fix help button to not be rude
// the whole equals calculation code is broken but im too fucking tired to fix this shit. i just need to reorganize the if statements

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
            double currentValue = double.Parse(MathResult.Text); // sets currentValue to whatever MathResult is but also "parses" it into a integer
            double result = currentValue / 100; // grabs result and divides it by 100
            MathResult.Text = result.ToString(); // gets result, translates it into string and slaps it in the result box
        }

        //
        // Math Type Button
        //

        private void MathOperatorHandler(object sender, EventArgs e) // i made this by selecting +, -, / and * and opening up properties in the bottom right and making a new click event handler
        {
            if (!string.IsNullOrEmpty(MathResult.Text))
            {
                firstNumber = double.Parse(MathResult.Text); // remembers what the first number was
                operation = ((Button)sender).Text; // remembers what math type the user selected
                MathResult.Text = (""); // clears the mathresult label
                isOperationClicked = true; // sets isoperationclicked to true
                MathTypeLabel.Text = operation; // sets the mathtypelabel as the math type that the user selected by checking what the value of operation is
            }
            else
            {
                MessageBox.Show("Please enter in numbers before you attempt to do calculations...");
            }
        }

        //
        // Main Math Code (when equals gets clicked)
        //

        private void MathEquals_Click(object sender, EventArgs e) // 
        {
            double secondNumber = double.Parse(MathResult.Text); // grabs whatever is in mathresult and converts it to "double" data type. reason for why im using double here is because it supports decimals
            double result = 0; // sets the result variable as 0 temporarily
            if (!string.IsNullOrEmpty(MathResult.Text)) 
            {
                switch (operation)
                {
                    case "+":
                        result = firstNumber + secondNumber; // if + was clicked then it will plus both numbers after = was pressed
                        break;
                    case "-":
                        result = firstNumber - secondNumber; // if - was clicked then it will minus the numbers after = is clicked
                        break;
                    case "X":
                        result = firstNumber * secondNumber; // if * was clicked then it will multiply. man its getting annoying rewriting this over and fucking over again WHEN ITS SELF EXPLANATORY BUT I LIKE HAVING COMMENTS >:(
                        break;
                    case "/":
                        // checks if the user is fucking around by checking if the user tried dividing something with 0 like a dumbass
                        if (secondNumber != 0) // if the second number isnt (it checks if it isnt because of the !) 0 then:
                        {
                            result = firstNumber / secondNumber; // if / was clicked then you know what no you already know what it does
                        }
                        else // there is so much fucking code i cannot keep track of this
                        {
                            MathResult.Text = "Error"; // if the user did attempt to divide something with 0 then show this message in the mathresult
                            return; // Exit the method
                        }
                        break; // exit the switch
                }
            }
            else if (operation == "") // if there is no +, -, * or / then show a message box that tells the user that they need to select one
                {
                    MessageBox.Show("You need to select the type of calculation!\nFor example '+', '*', '-' or '/'", "Error!");
                }
            else
            {
                // Display the final result
                MathResult.Text = result.ToString(); // converts the math result from double data to string data and puts it in MathResult

                // Reset the operation flag for the next calculation
                isOperationClicked = false; // sets isoperationclicked to false
                MathTypeLabel.Text = ""; // clears the mathtypelabel
            }
        }

        //
        // Other
        //

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            // paint? paint. PAINT!
        }


    }
} // huh
