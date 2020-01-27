using Gadz.Agenda.Access.DomainModel.Users;
using Gadz.Agenda.Common;

namespace Gadz.Agenda.Access.DomainModel.Rules {
    public interface IRule
    {
        Identity Id { get; }
        string Description { get; }
    }
}
