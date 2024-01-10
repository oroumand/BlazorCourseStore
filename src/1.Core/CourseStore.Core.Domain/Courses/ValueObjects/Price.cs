using Zamin.Core.Domain.Exceptions;
using Zamin.Core.Domain.ValueObjects;

namespace CourseStore.Core.Domain.Courses.ValueObjects
{
    public class Price : BaseValueObject<Price>
    {
        public long Value { get; private set; }

        public static Price FromLong(long value)
        {
            return new Price(value);
        }

        public Price(long value)
        {
            if (value <0)
            {
                throw new InvalidValueObjectStateException("VALIDATION_ERROR_NUMBER_GRATER_THAN", "Price");
            }
            Value = value;
        }

        private Price()
        {
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }

        public static explicit operator long(Price price)
        {
            return price.Value;
        }

        public static implicit operator Price(long value)
        {
            return new Price(value);
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
