using Gadz.Staff.Agenda.Commom.Model;
using Gadz.Staff.Agenda.Core.DomainModel.Horarios;
using Gadz.Staff.Agenda.Core.DomainModel.Pessoas;

namespace Gadz.Staff.Agenda.Core.DomainModel.Tarefas {
    public interface ITarefa : IEntity {
        IHorario Horario { get; }
        IPessoa Responsavel { get; }
        IPessoa Solicitante { get; }
        int DuracaoSegundos { get; }
        IStatusTarefa Status { get; }
    }
}