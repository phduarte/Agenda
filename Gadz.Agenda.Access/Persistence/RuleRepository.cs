﻿using Gadz.Agenda.Access.DomainModel;
using System;
using System.Collections.Generic;

namespace Gadz.Agenda.Access.Persistence
{
    internal class RuleRepository : IRuleRepository
    {
        public void Add(IRule rule)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IRule> AllFrom(IUser user)
        {
            throw new NotImplementedException();
        }

        public void Remove(Identity id)
        {
            throw new NotImplementedException();
        }
    }
}