# FizzBuzz

Apply Singe Responsibility like do the same operation but using different classes for each also will be useful for code reusability and extension of the classes in the future.
Code Separation is happening here like create and Interface for the display Rules for each scenario like
Fizz -> divided by 3
Buzz -> divided by 5
FizzBuzz -> divided by 3  and divided by 5
and call the interface IFizzBuzzRule in all the classes such as 
Class FizzRule
Class BuzzRule
Class FizzBuzzRule
Class DefaultRule -> which will just check the number and return the string result as an output.
