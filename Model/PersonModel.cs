namespace Pharma.API.Model
{
    public class PersonModel
    {
        public int PersonId { get; private set; }
        public string Name { get; set; }
        public string Cpf { get; set; }
        public string? Adress_Street { get; set; }
        public int? Adress_Number { get; set; }
        public string? Adress_District { get; set; }
        public string? Adress_City { get; set; }
        public string? Adress_Zipcode { get; set; }
        public string? Adress_Complement { get; set; }
        private readonly List<UserModel> _user = new List<UserModel>();
        public IReadOnlyCollection<UserModel> User => _user;
    }
}