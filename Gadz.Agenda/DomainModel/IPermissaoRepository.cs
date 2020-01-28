using System.Collections.Generic;

namespace Gadz.Agenda.DomainModel
{
    public interface IPermissaoRepository
    {
        void Add(IPermissao rule);

        void Remove(Identity id);

        IEnumerable<IPermissao> AllFrom(IUsuario user);
    }
}