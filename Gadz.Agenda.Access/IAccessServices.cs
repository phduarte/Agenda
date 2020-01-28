using Gadz.Agenda.Access.DomainModel;

namespace Gadz.Agenda.Access
{
    public interface IAccessServices
    {
        void AtualizarUsuario(IUser usuario);
        IUser BuscarUsuario(string usuario, string senha);
        void CadastrarUsuario(string login, string senha, string nome);
    }
}