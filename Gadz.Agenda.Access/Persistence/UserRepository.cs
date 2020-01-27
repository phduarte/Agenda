using Gadz.Agenda.Access.DomainModel;
using System.Collections.Generic;
using System.Linq;

namespace Gadz.Agenda.Access.Persistence
{
    internal class UserRepository : IUserRepository
    {
        private static IList<IUser> _cache = LoadCache();

        private static IList<IUser> LoadCache()
        {
            return new List<IUser> {
                new User{Name="Administrador", Username="admin", Password = "admin" },
                new User{Name="Paulo Henrique Fernandes Duarte", Username="pduarte", Password = "123" },
            };
        }

        public void Add(IUser usuario)
        {
            _cache.Add(usuario);
        }

        public bool Exist(string username)
        {
            var usuario = _cache.FirstOrDefault(x => x.Username.Equals(username));
            return usuario != null;
        }

        public IUser Get(string username, string password)
        {
            var usuario = _cache.FirstOrDefault(x => x.Username.Equals(username) && x.Password.Equals(password));
            return usuario;
        }

        public void Remove(Identity id)
        {
            var usuario = _cache.First(x => x.Id.Equals(id));
            _cache.Remove(usuario);
        }
    }
}