namespace MathOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum=int.Parse(Console.ReadLine());
            string operatorr=Console.ReadLine();
            int secondNum=int.Parse(Console.ReadLine());
            double result = Calculate(firstNum, operatorr, secondNum);
            Console.WriteLine(result);
        }

        static double Calculate(int firstNum,string operatorr, int secondNum)
        {
            double result = 0;
            switch (operatorr)
            {
                case "/":
                    result=firstNum/ secondNum;

                    break;
                case "*":
                    result = firstNum * secondNum;
                    break;
                case "+":
                    result = firstNum + secondNum;
                    break;
                case "-":
                    result = firstNum - secondNum;
                    break;

            }
            return result;
        }
    }
}