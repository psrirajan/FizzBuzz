using System;
using NUnitFramework;

/* Create an interface for injecting wherever needed for Single Responsibility and Code Separation Principle  */ 
public interface IFizzBuzzRule
    {
        bool Check(int number);
        string GetResult(int number);
    }

[TestMethod]
public void TestFizzRule() {
    FizzRule mockBuzzRule = new FizzRule();
    bool result_Fizztrueorfalse  = mockFizzRule.Check(int n) => n % 3 == 0;
    if (Assert.assertEqual(true, result_Fizztrueorfalse)) {
        string getResult_Fizz = mockFizzRule.GetResult(n);
        Assert.assertEqual("FizzRule", getResult_Fizz);
    }
}

[TestMethod]
public void TestBuzzRule() {
    BuzzRule mockBuzzRule = new BuzzRule();
    bool result_Buzztrueorfalse  = mockBuzzRule.Check(int n) => n % 3 == 0;
    if (Assert.assertEqual(true, result_Buzztrueorfalse)) {
        string getResult_Buzz = mockBuzzRule.GetResult(n);
        Assert.assertEqual("BuzzRule", getResult_Buzz);
    }
   
}

[TestMethod]
public voud TestFizzBuzzRule() {
    FizzBuzzRule mockFizzBuzzRule = new FizzBuzzRule();
    bool result_FizzBuzztrueorfalse  = mockFizzBuzzRule.Check(int n) => n % 3 == 0;
    if (Assert.assertEqual(true, result_FizzBuzztrueorfalse)) {
        string getResult_FizzBuzz = mockFizzBuzzRule.GetResult(n);
        Assert.assertEqual("FizzBuzzRule", getResult_FizzBuzz);
    }
    
}


[TestMethod]
public voud TestDefaultRule() {
    FizzBuzzRule mockDefaultRule = new DefaultRule();
    bool result_Defaulttrueorfalse  = mockDefaultRule.Check(int n) => n % 3 == 0;
    if (Assert.assertEqual(true, result_Defaulttrueorfalse)) {
        string getResult_Default = mockDefaultRule.GetResult(n);
        Assert.assertEqual("DefaultRule", getResult_Default);
    }
    
}

    [Set]
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
