using Gadz.Agenda.Access.DomainModel.Users;
using Gadz;

namespace Gadz.Agenda.Access.DomainModel.Rules {
    public interface IRule
    {
        Identity Id { get; }
        string Description { get; }
    }
}
