using Gadz.Agenda.Access.DomainModel.Users;
using Gadz;
using System.Collections.Generic;

namespace Gadz.Agenda.Access.DomainModel.Rules {
    internal interface IRuleRepository
    {
        void Add(IRule rule);
        void Remove(Identity id);
        IEnumerable<IRule> AllFrom(IUser user);
    }
}
