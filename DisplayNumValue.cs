using System;

/* Create an interface for injecting wherever needed for Single Responsibility and Code Separation Principle  */ 
public interface IFizzBuzzRule
    {
        bool Check(int number);
        string GetResult(int number);
    }

   /* Create a FizzBuzz class then inject IFizzBuzzRule Interface to do the operation for divided by 3 */
    class FizzRule : IFizzBuzzRule
    {
        public bool Check(int number) => number % 3 == 0;
        public string GetResult(int number) => "Fizz";
    }

    /* Create BuzzRule class then inject IFizzBuzz Ibterface to do the operation divided by 5 */
    class BuzzRule : IFizzBuzzRule
    {
        public bool Check(int number) => number % 5 == 0;
        public string GetResult(int number) => "Buzz";
    }

    /* Create FuzzBuzz class then inject the IFizzBuzzRule Interface to do the operation divided by 3 and divided by 5 */
    class FizzBuzzRule : IFizzBuzzRule
    {
        public bool Check(int number) => number % 3 == 0 && number % 5 == 0;
        public string GetResult(int number) => "Fizz Buzz";
    }

    class DefaultRule : IFizzBuzzRule
    {
        public bool Check(int number) => true;
        public string GetResult(int number) => number.ToString();
    }

    class FizzBuzz
    {
        private readonly IFizzBuzzRule[] rules;

        public FizzBuzz()
        {
           /* Create separate rules from the common rule IFizzBuzzRule */
            rules = new IFizzBuzzRule[]
            {
              new FizzBuzzRule(),
              new FizzRule(),
             new BuzzRule(),
             new DefaultRule()
            };
        }

        public string GetResult(int number)
        {
            foreach (var rule in rules)
            {
                if (rule.Check(number))
                    return rule.GetResult(number);
            }
            return number.ToString();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            FizzBuzz fizzBuzz = new FizzBuzz();

            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(fizzBuzz.GetResult(i));
            }
        }

    }
