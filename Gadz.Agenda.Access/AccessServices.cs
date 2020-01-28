using Gadz.Agenda.Access.DomainModel;
using Gadz.Agenda.Access.Persistence;

namespace Gadz.Agenda.Access
{
    public class AccessServices : IAccessServices
    {
        private static IUserRepository _usuarioRepository = new UserRepository();

        public AccessServices()
        {
        }

        public IUser BuscarUsuario(string usuario, string senha)
        {
            return _usuarioRepository.Find(usuario, senha);
        }

        public void CadastrarUsuario(string login, string senha, string nome)
        {
            var usuario = new User { Username = login, Password = senha, Name = nome };
            _usuarioRepository.Add(usuario);
        }

        public void AtualizarUsuario(IUser user)
        {
            var usuario = _usuarioRepository.Get(user.Id);
            _usuarioRepository.Save(usuario);
        }
    }
}