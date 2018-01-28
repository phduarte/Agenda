using Gadz.Staff.Access.DomainModel.Users;
using Gadz.Staff.Agenda.Commom.Model;

namespace Gadz.Staff.Access.DomainModel.Rules {
    public interface IRule
    {
        Identity Id { get; }
        string Description { get; }
    }
}
