using Gadz.Agenda.Access.DomainModel;
using Gadz;
using System.Collections.Generic;

namespace Gadz.Agenda.Access.DomainModel {
    public interface IUser
    {
        Identity Id { get; }
        string Username { get; }
        string Password { get; }
        string Name { get; }
        IList<IRule> Rules { get; }
    }
}
