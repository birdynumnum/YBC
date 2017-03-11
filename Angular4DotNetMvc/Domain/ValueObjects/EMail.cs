using System.Text.RegularExpressions;

namespace Domain.ValueObjects
{
    public class EMail : ValueObject<EMail>
    {
        private string _value;

        public string Value
        {
            get { return _value; }
            set { _value = value; }
        }

        private EMail()
        {

        }

        private EMail(string value)
        {
            _value = value;
        }

        public static Result<EMail> Create(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return Result.Fail<EMail>("Email should not be empty");

            email = email.Trim();
            if (email.Length > 256)
                return Result.Fail<EMail>("Email address is too long");

            if (!Regex.IsMatch(email, @"^(.+)@(.+)$"))
                return Result.Fail<EMail>("Email is invalid");

            return Result.Ok(new EMail(email));
        }

        protected override bool EqualsCore(EMail other)
        {
            return _value == other._value;
        }

        protected override int GetHashCodeCore()
        {
            return _value.GetHashCode();
        }

        public static explicit operator EMail(string email)
        {
            return Create(email).Value;
        }

        public static implicit operator string(EMail email)
        {
            return email._value;
        }
    }
}
