using Gadz.Agenda.DomainModel;

namespace Gadz.Agenda.Access.DomainModel
{
    internal class Permissao : IPermissao
    {
        public Identity Id { get; private set; }
        public string Description { get; internal set; }

        public Permissao()
        {
            Id = Identity.Create();
        }

        public Permissao(Identity id)
        {
            Id = id;
        }
    }
}