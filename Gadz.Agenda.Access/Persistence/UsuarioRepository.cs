using Gadz.Agenda.Access.DomainModel;
using Gadz.Agenda.DomainModel;
using System.Collections.Generic;
using System.Linq;

namespace Gadz.Agenda.Access.Persistence
{
    internal class UsuarioRepository : IUsuarioRepository
    {
        private static IList<IUsuario> _cache = LoadCache();

        private static IList<IUsuario> LoadCache()
        {
            return new List<IUsuario> {
                new Usuario{Nome="Administrador", Login="admin", Senha = "admin" },
                new Usuario{Nome="Paulo Henrique Fernandes Duarte", Login="pduarte", Senha = "123" },
            };
        }

        public void Add(IUsuario usuario)
        {
            _cache.Add(usuario);
        }

        public bool Exist(string username)
        {
            var usuario = _cache.FirstOrDefault(x => x.Login.Equals(username));
            return usuario != null;
        }

        public IUsuario Find(string username, string password)
        {
            var usuario = _cache.FirstOrDefault(x => x.Login.Equals(username) && x.Senha.Equals(password));
            return usuario;
        }

        public IUsuario Get(Identity id)
        {
            return _cache.FirstOrDefault(x => x.Id.Equals(id));
        }

        public void Remove(Identity id)
        {
            var usuario = _cache.First(x => x.Id.Equals(id));
            _cache.Remove(usuario);
        }

        public void Remove(IUsuario user)
        {
            _cache.Remove(user);
        }

        public void Save(IUsuario user)
        {
            Remove(user);
            Add(user);
        }
    }
}