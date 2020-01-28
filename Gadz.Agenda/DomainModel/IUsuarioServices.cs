namespace Gadz.Agenda.DomainModel
{
    public interface IUsuarioServices
    {
        void AtualizarUsuario(IUsuario usuario);
        IUsuario BuscarUsuario(string usuario, string senha);
        void CadastrarUsuario(string login, string senha, string nome);
    }
}