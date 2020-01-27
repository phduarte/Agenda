using Gadz;
using Gadz.Agenda.Core.DomainModel.Agendas;

namespace Gadz.Agenda.Core.DomainModel.Pessoas {
    public interface IPessoa : IEntity {
        Name Nome { get; }
        Telephone Telefone { get; }
        Email Email { get; }
        IAgenda Agenda { get; }
    }
}
