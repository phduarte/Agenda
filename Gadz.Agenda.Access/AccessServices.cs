using Gadz.Agenda.Access.DomainModel;
using Gadz.Agenda.Access.Persistence;
using Gadz.Agenda.DomainModel;

namespace Gadz.Agenda.Access
{
    public class AccessServices : IUsuarioServices
    {
        private static IUsuarioRepository _usuarioRepository = new UsuarioRepository();

        public AccessServices()
        {
        }

        public IUsuario BuscarUsuario(string usuario, string senha)
        {
            return _usuarioRepository.Find(usuario, senha);
        }

        public void CadastrarUsuario(string login, string senha, string nome)
        {
            var usuario = new Usuario { Login = login, Senha = senha, Nome = nome };
            _usuarioRepository.Add(usuario);
        }

        public void AtualizarUsuario(IUsuario user)
        {
            var usuario = _usuarioRepository.Get(user.Id);
            _usuarioRepository.Save(usuario);
        }
    }
}