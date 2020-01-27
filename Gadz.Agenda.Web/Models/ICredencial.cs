namespace Gadz.Agenda.Web.Models
{
    public interface ICredencial
    {
        string Login { get; set; }
        string Senha { get; set; }

        bool Valida();
    }
}