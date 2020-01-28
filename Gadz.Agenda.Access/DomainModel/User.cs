using System.Collections.Generic;

namespace Gadz.Agenda.Access.DomainModel
{
    internal class User : IUser
    {
        public Identity Id { get; private set; }
        public string Username { get; internal set; }
        public string Password { get; internal set; }
        public string Name { get; internal set; }
        public IList<IRule> Rules { get; set; } = new List<IRule>();

        public User()
        {
            Id = Identity.Create();
        }

        public User(Identity id)
        {
            Id = id;
        }

        public void AddRule(IRule rule)
        {
            Rules.Add(rule);
        }

        public void RemoveRule(IRule rule)
        {
            Rules.Remove(rule);
        }

        public void ResetPassword(string newPassword)
        {
            Password = newPassword;
        }
    }
}