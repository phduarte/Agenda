namespace Gadz.Agenda.DomainModel
{
    public interface IUsuarioRepository
    {
        void Add(IUsuario usuario);

        void Remove(Identity id);

        bool Exist(string username);

        IUsuario Find(string username, string password);
        IUsuario Get(Identity id);
        void Save(IUsuario usuario);
    }
}