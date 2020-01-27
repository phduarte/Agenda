namespace Gadz.Agenda.Core.DomainModel
{
    public interface ITarefa : IEntity
    {
        IHorario Horario { get; }
        IPessoa Responsavel { get; }
        IPessoa Solicitante { get; }
        int DuracaoSegundos { get; }
        IStatusTarefa Status { get; }
    }
}