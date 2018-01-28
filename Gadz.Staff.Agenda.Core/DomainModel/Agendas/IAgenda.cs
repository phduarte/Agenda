using Gadz.Staff.Agenda.Commom.Model;
using Gadz.Staff.Agenda.Core.DomainModel.Horarios;
using Gadz.Staff.Agenda.Core.DomainModel.Tarefas;
using System.Collections.Generic;

namespace Gadz.Staff.Agenda.Core.DomainModel.Agendas {
    public interface IAgenda : IEntity {
        IList<IHorario> Horarios { get; }
        IList<ITarefa> Tarefas { get; }
    }
}