namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        double firstNumber; // stores the first number when MathOperationHandler runs
        string operation = ""; // stores the math type thingy when MathOperationHandler runs
        bool isOperationClicked = false; // when math type is clicked this is set to true and clears MathResult
        public Form1() // this is here by default
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

        private void HelpButton_Click(object sender, EventArgs e) // a help button
        {
            MessageBox.Show("Enter a number then click a math type\nEnter another number and then either click a new math type or click equals to get your answer", "Help");
        }

        //
        // Backspace Button
        //

        private void MathBackspace_Click(object sender, EventArgs e) // removes 1 number when backspace is clicked
        {
            if (MathResult.Text.Length > 0)  // if there is more than 0 numbers in MathResult then:
            {
                MathResult.Text = MathResult.Text.Substring(0, MathResult.Text.Length - 1); // gets whatever is in mathresult and using substring it makes a new string with 1 less number bscly removing the last number like a backspace button should
            }
            else // if there isnt more than 0 numbers then:
            {
                MessageBox.Show("There are no numbers to remove.", "Error"); // hehe
            }
        }

        //
        // Clear Button
        //

        private void MathClear_Click(object sender, EventArgs e) // clear MathResult button
        {
            if (MathResult.Text.Length > 0) {  // checks if the mathresult is empty before proceeding
                MathResult.Text = (""); // clears MathResult
                operation = ""; // sets operaion to nothing aka the thing that remembers what was clicked like +, -, * or /
                isOperationClicked = false; // sets isOperationClicked to false
                MathTypeLabel.Text = ""; // clears the mathtypelabel
            }
        }

        //
        // Dot Button
        //

        private void MathDot_Click(object sender, EventArgs e) // adds a decimal
        {
            MathResult.Text += "."; // idk if this works but we ball. spoilers: it did work
        }

        //
        // Number Buttons
        //

        private void NumberButtonClick(object sender, EventArgs e) // on number click
        {
            string NumberInButton = ((Button)sender).Text; // get what number was clicked

            if (MathResult.Text.Length < 20) // adds a check to check if there is less than 20 numbers in box. if there is less than 20 then add number if more than 20 then show error
            { 
                if (isOperationClicked) // checks if isOperationClicked is true
                {   
                    isOperationClicked = false; // if isOperationClicked = true then make it false
                    MathResult.Text += NumberInButton; // add the number that was clicked from string NumberInButton
                    // i have the isOperationClicked thing so the code knows when to start on a new number
                }
                else
                {
                    MathResult.Text += NumberInButton; // add the number that was clicked from string NumberInButton
                }
            }
            else // if there are more than 20 numbers. the reason to why i did this is just because i didnt know what to do to fix the issue of numbers going off the screen
            {
                MessageBox.Show("There are more than 20 numbers. Unable to fit more in box.", "Error");
            }
        }
        // dude help this is complicated my brain hurts aaaaa

        //
        // Percentage Button
        //

        private void MathPercent_Click(object sender, EventArgs e) // percentage button thingy
        {
            if (string.IsNullOrEmpty(MathResult.Text)) // checks if mathresult is empty
            {
                MessageBox.Show("Please enter a number first.", "Error");
                return; // return is important here cuz if i dont have it then crash happens. it stops the rest of the code in this button from running if ran
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
            if (string.IsNullOrEmpty(MathResult.Text)) // checks if mathresult is empty
            {
                MessageBox.Show("Please enter a number first.", "Error");
                return; // gotta have this here to avoid crash cuz if u click a operator when there is no numbers after a operator has already been clicked then it crashes
            }
            if (!string.IsNullOrEmpty(operation)) // checks if there isnt a active operation
            {
                // if there is a operation waiting then do the calculation now
                MathEquals_Click(sender, e); // runs the mathequals code
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
            switch (operation) // switch based off of what the operation is
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
            MathResult.Text = result.ToString(); // puts result in mathresult and also converts it into string

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
