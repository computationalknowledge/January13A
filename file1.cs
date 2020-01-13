using System;

namespace C0999999
{
    class Controller
    {
        static void Main(string[] args)
        {
            ProblemData pd = new ProblemData();
            Console.ReadLine();
        }
    }

    class Calculator
    {

    }
    class ProblemData
    {
        public ProblemData(){
            //Note : this is the constructor
                Console.WriteLine("a");
            }
        int num1;
        int num2;
        public void GetUserInput()
        {
            num1 = Convert.ToInt16(Console.ReadLine());
            num2 = Convert.ToInt16(Console.ReadLine());
        }
    }
}
