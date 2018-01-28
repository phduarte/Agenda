using Gadz.Staff.Agenda.Commom.Model;
using System;

namespace Gadz.Staff.Agenda.Core.DomainModel.Horarios {
    public interface IHorario : IEntity {
        DateTime Data { get; }
    }
}
