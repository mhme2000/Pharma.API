namespace Pharma.API.Model
{
    public class PersonModel
    {
        public int PersonId { get; private set; }
        public string Name { get; set; }
        public string Cpf { get; set; }

        private readonly List<UserModel> _user = new List<UserModel>();
        public IReadOnlyCollection<UserModel> User => _user;

        private readonly List<AddressModel> _addresses = new List<AddressModel>();
        public IReadOnlyCollection<AddressModel> Addresses => _addresses;
    }
}