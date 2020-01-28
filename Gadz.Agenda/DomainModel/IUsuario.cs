using System.Collections.Generic;

namespace Gadz.Agenda.DomainModel
{
    public interface IUsuario : IPessoa
    {
        string Login { get; }
        string Senha { get; }
        Email Email { get; }
        IList<IPermissao> Permissoes { get; }

        void AlterarSenha(string senha);
    }
}