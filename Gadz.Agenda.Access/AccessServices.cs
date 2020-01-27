using Gadz.Agenda.Access.DomainModel;
using Gadz.Agenda.Access.Persistence;

namespace Gadz.Agenda.Access {
    public class AccessServices {

        static IUserRepository _usuarioRepository = new UserRepository();

        public AccessServices() {

        }

        public IUser BuscarUsuario(string usuario, string senha) {
            return _usuarioRepository.Get(usuario, senha);
        }

        public void CadastrarUsuario(string login, string senha, string nome) {
            var usuario = new User { Username = login, Password = senha, Name = nome };
            _usuarioRepository.Add(usuario);
        }
    }
}
