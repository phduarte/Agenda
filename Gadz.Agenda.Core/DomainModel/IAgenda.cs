using System.Collections.Generic;

namespace Gadz.Agenda.Core.DomainModel
{
    public interface IAgenda : IEntity
    {
        IList<IHorario> Horarios { get; }
        IList<ITarefa> Tarefas { get; }
    }
}