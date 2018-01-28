using Gadz.Staff.Access.DomainModel.Rules;
using System.Collections.Generic;

namespace Gadz.Staff.Access.DomainModel.Users {
    public interface IUser
    {
        Identity Id { get; }
        string Username { get; }
        string Password { get; }
        string Name { get; }
        IList<IRule> Rules { get; }
    }
}
