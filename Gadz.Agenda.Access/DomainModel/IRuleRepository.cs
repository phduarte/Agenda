using Gadz.Agenda.Access.DomainModel;
using Gadz;
using System.Collections.Generic;

namespace Gadz.Agenda.Access.DomainModel {
    internal interface IRuleRepository
    {
        void Add(IRule rule);
        void Remove(Identity id);
        IEnumerable<IRule> AllFrom(IUser user);
    }
}
