namespace Gadz.Agenda.Common {
    public struct Telephone
    {
        public string Ddd { get; private set; }
        public string Number { get; private set; }

        public Telephone(string telefone) {
            Ddd = telefone.Substring(0, 2);
            Number = telefone.Substring(2);
        }

        public override string ToString() {
            return $"({Ddd}) {Number}";
        }
    }
}
