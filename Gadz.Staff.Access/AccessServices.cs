using Gadz.Staff.Access.DomainModel.Users;
using Gadz.Staff.Access.Infrastructure.Data;

namespace Gadz.Staff.Access {
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
