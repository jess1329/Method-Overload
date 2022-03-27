using System;

namespace Method_Overloading
{
    internal class Program
    {
        public static int Add(int num1, int num2)

        {
            return int num1 + int num2;
        }
        public static decimal Add(decimal num1, decimal num2)
        {
            return decimal 1 + decimal 2;
        }

        public static string Add(int num1, int num2, bool isTrue) 
        {    
            var sum = 0
            string response = "";

            if (isTrue)
            {
                sum = num1 + num2;

                if (sum == 1)
                {
                    response = $"(sum) dollar.";
                }
                else 
                {
                    response = $"(sum) dollars";
                }
                return response;    





        }
            
        
            {
            
}





        static void Main(string[] args)

        var x = 29;
        var y = 55;
            var answer = Add(x, y);

            var a = 32.0 m;
            var b = 45.0 m;

            var decimalanswer = Add(a, b);

            var thirdAnswer = Add(0, 0 true);
            Console.WriteLine($" int add: {answer} decimal add: {decimal answer} ");
            Console.WriteLine(thirdAnswer);
            
            
    }
}
