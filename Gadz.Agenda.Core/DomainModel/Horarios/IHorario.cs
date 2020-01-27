using Gadz.Agenda.Common;
using System;

namespace Gadz.Agenda.Core.DomainModel.Horarios {
    public interface IHorario : IEntity {
        DateTime Data { get; }
    }
}
