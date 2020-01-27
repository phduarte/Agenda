using Gadz.Agenda.Common;
using Gadz.Agenda.Core.DomainModel.Horarios;
using Gadz.Agenda.Core.DomainModel.Tarefas;
using System.Collections.Generic;

namespace Gadz.Agenda.Core.DomainModel.Agendas {
    public interface IAgenda : IEntity {
        IList<IHorario> Horarios { get; }
        IList<ITarefa> Tarefas { get; }
    }
}