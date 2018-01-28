using System;

namespace Gadz.Agenda.Commom.Model {
    public struct Identity
    {
        string _id;

        public Identity(string id) {
            _id = id;
        }

        public static Identity Create() {
            return new Identity(Guid.NewGuid().ToString());
        }

        public override bool Equals(object obj) {
            if(obj is Identity id) {
                return ToString().Equals(id.ToString());
            }

            return false;
        }

        public override int GetHashCode() {
            return _id.GetHashCode();
        }

        public override string ToString() {
            return _id;
        }
    }
}
