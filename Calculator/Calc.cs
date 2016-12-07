using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Diagnostics;


namespace Calculator
{
    public class Calc
    {
        public string Display;                                              //Creates the variable 'Display', which is used to keep track of what is displayed on the screen.
        private string FirstNumber;                                         //Creates the veriable 'FirstNumber', which is used to store the first number in a calculation.
        private bool NewOperation;                                          //Creates the variable 'NewOperation', which is used to check whether the last button pressed was an operation.
        private ButtonOption? CurrentOperation;                             //Creates the variable 'CurrentOperation', which is used to store the operation that will be performed.

        public enum ButtonOption
        {
            Add, Subtract, Multiply, Divide, Clear, Equals, Number          //List of options that 'CurrentOperation' could be.
        }

        public Calc()
        {
            Reset();                                                        //Resets the calculator (and sets the variables to defaults) when the program is first run.
        }

        public string ProcessButton(ButtonOption Btn, string Num = "")      //This is what happens whenever a button is pressed.
        {
            switch (Btn)                                                    //Which button is pressed will decide what the program should do.
            {
                case ButtonOption.Clear:                                    //If the Clear button is pressed:
                    Reset();                                                //Do predefined process 'Reset' (see below).
                    break;
                case ButtonOption.Add:                                      //If the Add button is pressed,
                case ButtonOption.Subtract:                                 //Or the Subtract button is pressed,
                case ButtonOption.Multiply:                                 //Or the Multiply button is pressed,
                case ButtonOption.Divide:                                   //Or the Divide button is pressed:
                    if (CurrentOperation != null)                           
                    {
                        CalculateResult();                                  //If an operation button has already been pressed, do predefined process 'CalculateResult'.
                    }
                    NewOperation = true;                                    //Store True to NewOperation.
                    CurrentOperation = Btn;                                 //Store the operation button that was pressed to CurrentOperation.
                    break;
                case ButtonOption.Equals:                                   //If the Equals button is pressed:
                    CalculateResult();                                      //Do predefined process 'CalculateResult'.
                    NewOperation = true;                                    //Store True to NewOperation.
                    break;
                default:                                                    //If any other button is pressed (a number button):
                    if (NewOperation == true)                               //If the last button that was pressed was an operation button,
                    {
                        NewOperation = false;                               //Store False to NewOperation.
                        FirstNumber = Display;                              //Store the number that is on the display as FirstNumber.
                        Display = "0";                                      //Reset Display to 0.
                    }
                    if (Display == "0")                                     //If Display is 0,
                    {
                        Display = Num;                                      //Display the number that has been pressed.
                    }
                    else                                                    //If Display is not 0 (so a number has already been pressed),
                    {
                        Display += Num;                                     //Put the number that was pressed on the end on the number that is on the display.
                    }
                    break;
            }
            return Display;                                                 //Show the variable 'Display' on screen.
        }

        public void Reset()                                                 //This is what will happen when the program uses the predefined process 'Reset':
        {
            Display = "0";                                                  //Clear Display (set it to 0).
            FirstNumber = "";                                               //Clear FirstNumber (set it to empty).
            CurrentOperation = null;                                        //Clear CurrentOperation (set it to null).
            NewOperation = false;                                           //Store False to NewOperation.
        }

        public void CalculateResult()                                       //This is what will happen when the program uses the predefined process 'Reset':
        {
            if (FirstNumber != "")                                          //If there has been a number typed and an operation pressed:
            {
                Double FirstNum = Double.Parse(FirstNumber);                //Convert the first number (FirstNumber) to a double and store it as 'FirstNum'.
                Double SecondNum = Double.Parse(Display);                   //Convert the second number (on the display) to a double and store it as 'FirstNum'.
                switch (CurrentOperation)                                   //Which operation button was pressed will decide what calculation should be performed.
                {
                    case ButtonOption.Add:                                  //If the Add button was pressed:
                        Display = (FirstNum + SecondNum).ToString();        //Store the answer of the first number added to the second number as 'Display'.
                        break;
                    case ButtonOption.Subtract:                             //If the Subtract button was pressed:
                        Display = (FirstNum - SecondNum).ToString();        //Store the answer of the second number subtracted from the first number as 'Display'.
                        break;
                    case ButtonOption.Multiply:                             //If the Add button was pressed:
                        Display = (FirstNum * SecondNum).ToString();        //Store the answer of the first number multiplied by the second number as 'Display'.
                        break;
                    case ButtonOption.Divide:                               //If the Add button was pressed:
                        Display = (FirstNum / SecondNum).ToString();        //Store the answer of the first number divided by the second number as 'Display'.
                        break;
                }
                FirstNumber = "";                                           //Clear FirstNumber (set it to empty).
                CurrentOperation = null;                                    //Clear CurrentOperation (set it to null).
            }
        }
    }
}