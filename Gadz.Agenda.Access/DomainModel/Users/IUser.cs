using Gadz.Agenda.Access.DomainModel.Rules;
using Gadz;
using System.Collections.Generic;

namespace Gadz.Agenda.Access.DomainModel.Users {
    public interface IUser
    {
        Identity Id { get; }
        string Username { get; }
        string Password { get; }
        string Name { get; }
        IList<IRule> Rules { get; }
    }
}
