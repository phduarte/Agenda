using Gadz.Agenda.Access.DomainModel;
using Gadz;

namespace Gadz.Agenda.Access.DomainModel {
    public interface IRule
    {
        Identity Id { get; }
        string Description { get; }
    }
}
