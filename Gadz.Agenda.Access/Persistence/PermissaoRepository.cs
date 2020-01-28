using Gadz.Agenda.DomainModel;
using System;
using System.Collections.Generic;

namespace Gadz.Agenda.Access.Persistence
{
    internal class PermissaoRepository : IPermissaoRepository
    {
        public void Add(IPermissao rule)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IPermissao> AllFrom(IUsuario user)
        {
            throw new NotImplementedException();
        }

        public void Remove(Identity id)
        {
            throw new NotImplementedException();
        }
    }
}