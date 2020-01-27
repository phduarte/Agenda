using Gadz;
using System;

namespace Gadz.Agenda.Core.DomainModel {
    public interface IHorario : IEntity {
        DateTime Data { get; }
    }
}
