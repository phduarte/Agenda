using Gadz;

namespace Gadz.Agenda.Access.DomainModel {
    internal class Rule : IRule {

        public Identity Id { get; private set; }
        public string Description { get; internal set; }

        public Rule() {
            Id = Identity.Create();
        }

        public Rule(Identity id) {
            Id = id;
        }
    }
}
