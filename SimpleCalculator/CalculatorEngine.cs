using System;


namespace SimpleCalculator
{
    public class CalculatorEngine
    {
        public double Calculate(string argOperation, double argFirstNumber, double argSecondNumber)
        {
            double result;
            switch (argOperation.ToLower())
            {
                case "ADD":
                case "Add":
                case "add":
                case "+":
                    result = argFirstNumber + argSecondNumber;
                    break; 
                case "Subtract":
                case "subtract":
                case "SUBTRACT":
                case "-":
                    result = argFirstNumber - argSecondNumber;
                    break;
                case "MULTIPLY":
                case "Multiply":
                case "multiply":
                case "*":
                    result = argFirstNumber * argSecondNumber;
                    break;
                case "DIVISION":
                case "Division":
                case "division":
                case "/":
                    result = argFirstNumber / argSecondNumber;
                    break;
                default:
                    throw new InvalidOperationException("Specified Operation is nor recognized...");
            }
            return result;
        }
    }
}
