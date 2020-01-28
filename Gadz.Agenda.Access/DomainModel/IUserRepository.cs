namespace Gadz.Agenda.Access.DomainModel
{
    public interface IUserRepository
    {
        void Add(IUser usuario);

        void Remove(Identity id);

        bool Exist(string username);

        IUser Find(string username, string password);
        IUser Get(Identity id);
        void Save(IUser usuario);
    }
}