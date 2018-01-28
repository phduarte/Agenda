using Gadz.Staff.Access.DomainModel;
using Gadz.Staff.Access.DomainModel.Rules;
using Gadz.Staff.Access.DomainModel.Users;
using Gadz.Staff.Agenda.Commom.Model;
using System;
using System.Collections.Generic;

namespace Gadz.Staff.Access.Infrastructure.Data {
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
