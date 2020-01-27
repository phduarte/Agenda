using System;
using System.Collections.Generic;
using System.Text;

namespace Gadz
{
    public struct Email
    {
        public string Alias { get; private set; }
        public string Domain { get; private set; }
        public bool IsValid { get; private set; }

        public Email(string email) {
            Alias = email;
            Domain = email;
            IsValid = true;
        }

        public override string ToString() {
            return $"{Alias}@{Domain}";
        }
    }
}
