using Gadz.Agenda.Access.DomainModel;
using Gadz.Agenda.Access.DomainModel.Rules;
using Gadz.Agenda.Access.DomainModel.Users;
using Gadz;
using System;
using System.Collections.Generic;

namespace Gadz.Agenda.Access.Infrastructure.Data {
    internal class RuleRepository : IRuleRepository {

        public void Add(IRule rule) {
            throw new NotImplementedException();
        }

        public IEnumerable<IRule> AllFrom(IUser user) {
            throw new NotImplementedException();
        }

        public void Remove(Identity id) {
            throw new NotImplementedException();
        }
    }
}
