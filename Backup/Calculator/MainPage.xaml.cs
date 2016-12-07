using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace Calculator
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            MyCalc = new Calc();
            OutputBox.Text = MyCalc.Display;
        }

        Calc MyCalc;

        private void Button0_Click(object sender, RoutedEventArgs e)
        {
            OutputBox.Text = MyCalc.ProcessButton(Calc.ButtonOption.Number, "0");
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            OutputBox.Text = MyCalc.ProcessButton(Calc.ButtonOption.Number, "1");
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            OutputBox.Text = MyCalc.ProcessButton(Calc.ButtonOption.Number, "2");
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            OutputBox.Text = MyCalc.ProcessButton(Calc.ButtonOption.Number, "3");
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            OutputBox.Text = MyCalc.ProcessButton(Calc.ButtonOption.Number, "4");
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            OutputBox.Text = MyCalc.ProcessButton(Calc.ButtonOption.Number, "5");
        }

        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            OutputBox.Text = MyCalc.ProcessButton(Calc.ButtonOption.Number, "6");
        }

        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            OutputBox.Text = MyCalc.ProcessButton(Calc.ButtonOption.Number, "7");
        }

        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            OutputBox.Text = MyCalc.ProcessButton(Calc.ButtonOption.Number, "8");
        }

        private void Button9_Click(object sender, RoutedEventArgs e)
        {
            OutputBox.Text = MyCalc.ProcessButton(Calc.ButtonOption.Number, "9");
        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            OutputBox.Text = MyCalc.ProcessButton(Calc.ButtonOption.Add);
        }

        private void ButtonSubtract_Click(object sender, RoutedEventArgs e)
        {
            OutputBox.Text = MyCalc.ProcessButton(Calc.ButtonOption.Subtract);
        }

        private void ButtonMultiply_Click(object sender, RoutedEventArgs e)
        {
            OutputBox.Text = MyCalc.ProcessButton(Calc.ButtonOption.Multiply);
        }

        private void ButtonDivide_Click(object sender, RoutedEventArgs e)
        {
            OutputBox.Text = MyCalc.ProcessButton(Calc.ButtonOption.Divide);
        }

        private void ButtonClear_Click(object sender, RoutedEventArgs e)
        {
            OutputBox.Text = MyCalc.ProcessButton(Calc.ButtonOption.Clear);
        }

        private void ButtonEquals_Click(object sender, RoutedEventArgs e)
        {
            OutputBox.Text = MyCalc.ProcessButton(Calc.ButtonOption.Equals);
        }
    }
}