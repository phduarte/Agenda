using System.Collections.Generic;

namespace Gadz.Agenda.DomainModel
{
    public interface IAgenda : IEntity
    {
        IList<IHorario> Horarios { get; }
        IList<ITarefa> Tarefas { get; }
    }
}