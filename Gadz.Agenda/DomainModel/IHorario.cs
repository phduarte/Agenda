using System;

namespace Gadz.Agenda.DomainModel
{
    public interface IHorario : IEntity
    {
        DateTime Data { get; }
    }
}