namespace Gadz.Agenda.DomainModel
{
    public interface IAnalista : IUsuario
    {
        IAgenda Agenda { get; }
    }
}
