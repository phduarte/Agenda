using Gadz.Agenda.Common;
using Gadz.Agenda.Core.DomainModel.Horarios;
using Gadz.Agenda.Core.DomainModel.Pessoas;

namespace Gadz.Agenda.Core.DomainModel.Tarefas {
    public interface ITarefa : IEntity {
        IHorario Horario { get; }
        IPessoa Responsavel { get; }
        IPessoa Solicitante { get; }
        int DuracaoSegundos { get; }
        IStatusTarefa Status { get; }
    }
}