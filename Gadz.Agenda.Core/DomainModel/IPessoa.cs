using Gadz;
using Gadz.Agenda.Core.DomainModel;

namespace Gadz.Agenda.Core.DomainModel {
    public interface IPessoa : IEntity {
        Name Nome { get; }
        Telephone Telefone { get; }
        Email Email { get; }
        IAgenda Agenda { get; }
    }
}
