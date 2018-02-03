
namespace todolist
{
    class UserManager
    {
        private string _name;
        private string _userName;
        private string _accessToken;

        public string Name { get => _name; set => _name = value; }
        public string UserName { get => _userName; set => _userName = value; }
        public string AccessToken { get => _accessToken; set => _accessToken = value; }

        public UserManager(string name, string userName, string accessToken)
        {
            _name = name;
            _userName = userName;
            _accessToken = accessToken;
        }
    }
}
