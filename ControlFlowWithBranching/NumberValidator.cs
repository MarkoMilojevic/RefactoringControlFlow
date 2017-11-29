using System;

namespace ControlFlowWithBranching
{
    public class NumberValidator
    {
        private bool _shouldBePositive;
        private bool _shouldBeNegative;
        private bool _shouldBeOdd;
        private bool _shouldBeEven;
        private bool _shouldBeInRangeFromZero;
        private int _range;

        public NumberValidator ShouldBePositive()
        {
            _shouldBePositive = true;
            _shouldBeNegative = false;
            return this;
        }

        public NumberValidator ShouldBeNegative()
        {
            _shouldBeNegative = true;
            _shouldBePositive = false;
            return this;
        }

        public NumberValidator ShouldBeOdd()
        {
            _shouldBeOdd = true;
            _shouldBeEven = false;
            return this;
        }

        public NumberValidator ShouldBeEven()
        {
            _shouldBeEven = true;
            _shouldBeOdd = false;
            return this;
        }

        public NumberValidator ShouldBeInRangeFromZero(int range)
        {
            _shouldBeInRangeFromZero = true;
            _range = range;
            return this;
        }

        public bool Validate(int number)
        {
            if (_shouldBePositive && number < 0)
            {
                return false;
            }

            if (_shouldBeNegative && number > 0)
            {
                return false;
            }

            if (_shouldBeOdd && number % 2 == 0)
            {
                return false;
            }

            if (_shouldBeEven && number % 2 == 1)
            {
                return false;
            }

            if (_shouldBeInRangeFromZero && _range <= Math.Abs(number))
            {
                return false;
            }

            return true;
        }
    }
}
