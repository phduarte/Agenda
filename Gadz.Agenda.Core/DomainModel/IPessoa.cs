namespace Gadz.Agenda.Core.DomainModel
{
    public interface IPessoa : IEntity
    {
        Name Nome { get; }
        Phone Telefone { get; }
        Email Email { get; }
        IAgenda Agenda { get; }
    }
}