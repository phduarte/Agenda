using System.Linq;

namespace Gadz
{
    public struct Name
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public Name(string name)
        {
            var c = name.Split();
            if (c.Length > 1)
            {
                FirstName = c[0];
                LastName = string.Join(" ", c.Skip(1));
            }
            else
            {
                FirstName = name;
                LastName = string.Empty;
            }
        }

        public static implicit operator Name(string name)
        {
            return new Name(name);
        }

        public static implicit operator string(Name name)
        {
            return name.ToString();
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}