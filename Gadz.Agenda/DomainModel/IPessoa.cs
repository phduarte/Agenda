namespace Gadz.Agenda.DomainModel
{
    public interface IPessoa : IEntity
    {
        Name Nome { get; }
        Phone Telefone { get; }
        
    }
}