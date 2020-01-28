using Gadz.Agenda.DomainModel;
using System.Collections.Generic;

namespace Gadz.Agenda.Access.DomainModel
{
    internal class Usuario : IUsuario
    {
        public Identity Id { get; private set; }
        public string Login { get; internal set; }
        public string Senha { get; internal set; }
        public Name Nome { get; internal set; }
        public IList<IPermissao> Permissoes { get; set; } = new List<IPermissao>();
        public Email Email { get; set; }
        public Phone Telefone { get; set; }

        public Usuario()
        {
            Id = Identity.Create();
        }

        public Usuario(Identity id)
        {
            Id = id;
        }

        public void AdicionarPermissao(IPermissao permissao)
        {
            Permissoes.Add(permissao);
        }

        public void RemoverPermissao(IPermissao permissao)
        {
            Permissoes.Remove(permissao);
        }

        public void AlterarSenha(string novaSenha)
        {
            Senha = novaSenha;
        }
    }
}