using Gadz.Staff.Agenda.Commom.Model;
using Gadz.Staff.Agenda.Core.DomainModel.Agendas;

namespace Gadz.Staff.Agenda.Core.DomainModel.Pessoas {
    public interface IPessoa : IEntity {
        Name Nome { get; }
        Telephone Telefone { get; }
        Email Email { get; }
        IAgenda Agenda { get; }
    }
}
