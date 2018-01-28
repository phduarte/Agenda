using Gadz.Staff.Access.DomainModel.Users;
using System.Collections.Generic;

namespace Gadz.Staff.Access.DomainModel.Rules {
    internal interface IRuleRepository
    {
        void Add(IRule rule);
        void Remove(Identity id);
        IEnumerable<IRule> AllFrom(IUser user);
    }
}
