namespace Pharma.API.Model
{
    public class PharmaModel
    {
        public int PharmaId { get; private set; }
        public string PharmaName { get; set; }
        private readonly List<UserModel> _users = new List<UserModel>();
        public IReadOnlyCollection<UserModel> Users => _users;
    }
}