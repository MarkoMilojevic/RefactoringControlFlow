using System;
using System.Collections.Generic;
using System.Linq;

namespace RefactoredControlFlow
{
    public class NumberValidator
    {
        private static readonly Func<int, bool> NoValidation = (number) => true;

        private Func<int, bool> _positive = NoValidation;
        private Func<int, bool> _negative = NoValidation;
        private Func<int, bool> _even = NoValidation;
        private Func<int, bool> _odd = NoValidation;
        private Func<int, bool> _rangeFromZero = NoValidation;

        private readonly List<Func<int, bool>> _validators;

        public NumberValidator()
        {
            _validators = new List<Func<int, bool>>
            {
                _positive,
                _negative,
                _odd,
                _even,
                _rangeFromZero
            };
        }

        public NumberValidator ShouldBePositive()
        {
            _positive = (number) => number > 0;
            _negative = NoValidation;
            return this;
        }

        public NumberValidator ShouldBeNegative()
        {
            _positive = NoValidation;
            _negative = (number) => number < 0;
            return this;
        }

        public NumberValidator ShouldBeOdd()
        {
            _odd = (number) => number % 2 == 1;
            _even = NoValidation;
            return this;
        }

        public NumberValidator ShouldBeEven()
        {
            _odd = NoValidation;
            _even = (number) => number % 2 == 0;
            return this;
        }

        public NumberValidator ShouldBeInRangeFromZero(int range)
        {
            _rangeFromZero = (number) => Math.Abs(number) <= range;
            return this;
        }

        public bool Validate(int number)
        {
            return _validators.All(validate => validate(number));
        }
    }
}
