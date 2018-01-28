using Gadz.Staff.Access.DomainModel.Users;

namespace Gadz.Staff.Access.DomainModel.Rules {
    public interface IRule
    {
        Identity Id { get; }
        string Description { get; }
    }
}
