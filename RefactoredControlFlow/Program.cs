using System;

namespace RefactoredControlFlow
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var validator = new NumberValidator()
                .ShouldBePositive()
                .ShouldBeEven()
                .ShouldBeInRangeFromZero(100);

            Console.WriteLine("Positive, even, -100 <= x <= 100");
            Console.WriteLine($"50: {validator.Validate(50)}");
            Console.WriteLine($"51: {validator.Validate(51)}");
            Console.WriteLine($"151: {validator.Validate(51)}");

            validator = new NumberValidator()
                .ShouldBeNegative()
                .ShouldBeOdd()
                .ShouldBeInRangeFromZero(10);

            Console.WriteLine();

            Console.WriteLine("Negative, odd, -10 <= x <= 10");
            Console.WriteLine($"-5: {validator.Validate(-5)}");
            Console.WriteLine($"-2: {validator.Validate(-2)}");
            Console.WriteLine($"-21: {validator.Validate(-21)}");

            Console.WriteLine();

            new Workflow()
                .Ready().Execute()
                .Active().Execute()
                .Complete().Execute();

            Console.WriteLine();

            new Workflow(Workflows.Accounting)
                .Ready().Execute()
                .Active().Execute()
                .Complete().Execute();

            Console.WriteLine();

            new Workflow(Workflows.HR)
                .Ready().Execute()
                .Active().Execute()
                .Complete().Execute();

            Console.ReadKey();
        }
    }
}
