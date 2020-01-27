namespace Gadz.Agenda.Access.DomainModel
{
    public interface IRule
    {
        Identity Id { get; }
        string Description { get; }
    }
}