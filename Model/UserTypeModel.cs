namespace Pharma.API.Model
{
    public class UserTypeModel
    {
        public int UserTypeId { get; private set; }
        public UserType Description { get; set; }
        private readonly List<UserModel> _users = new List<UserModel>();
        public IReadOnlyCollection<UserModel> Users => _users;
    }

    public enum UserType
    {
        Cliente = 1,
        Gerente = 2,
        Farmaceutico = 3,
        Estoquista = 4,
    }
}