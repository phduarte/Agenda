﻿using Gadz.Agenda.Commom.Model;

namespace Gadz.Agenda.Access.DomainModel.Users {
    public interface IUserRepository {
        void Add(IUser usuario);
        void Remove(Identity id);
        bool Exist(string username);
        IUser Get(string username, string password);
    }
}
