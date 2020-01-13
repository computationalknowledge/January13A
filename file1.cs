using System;

namespace C0999999
{
    class Controller
    {
        static void Main(string[] args)
        {
            ProblemData pd = new ProblemData();
            Calculator calc = new Calculator(pd);
            Console.WriteLine(calc.Add());
            
        }
    }

    class Calculator
    {
        ProblemData probData;

        public Calculator(ProblemData pData)
        {
            probData = pData;
        }
        public int Add() {
            return probData.num1 + probData.num1;
        }
    }
    class ProblemData
    {
        public ProblemData(){
                //Note : this is the constructor
                Console.WriteLine("  this is the constructor  ");
                this.GetUserInput();
            }

        public int num1;
        public int num2;

        public void GetUserInput()
        {
            // num1 = Convert.ToInt32(Console.ReadLine());
            // num2 = Convert.ToInt32(Console.ReadLine());
            num1 = 6;
            num2 = 3;
        }
    }
}
