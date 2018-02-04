
namespace todolist
{
    /// <summary>
    /// This class contains all the informations about the user
    /// </summary>
    class UserManager
    {
        private string _name; ///> the name of the user
        private string _userName; ///> the username of the user
        private string _accessToken; ///> the MS accessToken

        public string Name { get => _name; set => _name = value; }
        public string UserName { get => _userName; set => _userName = value; }
        public string AccessToken { get => _accessToken; set => _accessToken = value; }

        /// <summary>
        /// Constructor of the user manager
        /// </summary>
        /// <param name="name"></param>
        /// <param name="userName"></param>
        /// <param name="accessToken"></param>
        public UserManager(string name, string userName, string accessToken)
        {
            _name = name;
            _userName = userName;
            _accessToken = accessToken;
        }
    }
}
