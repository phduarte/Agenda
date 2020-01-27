namespace Gadz.Agenda.Access.DomainModel
{
    public interface IUserRepository
    {
        void Add(IUser usuario);

        void Remove(Identity id);

        bool Exist(string username);

        IUser Get(string username, string password);
    }
}