namespace Gadz.Agenda.Common {
    public abstract class Entity : IEntity
    {
        public Identity Id { get; private set; }

        protected Entity() {
            Id = Identity.Create();
        }

        protected Entity(Identity id) {
            Id = id;
        }
    }
}
